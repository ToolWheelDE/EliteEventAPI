using EliteEventAPI.Services;
using EliteEventAPI.Services.Journal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace EliteEventAPI.Services.Transmitter.EDSM
{
    public sealed class EDSMJournalSync : ServiceBase
    {
        private readonly Queue<(string, string)> _queue = new Queue<(string, string)>();
        private string apiKey;
        private string commandername;
        private string applicationName;
        private string applicationVersion;

        public override string Name => "EDSM Sync Service";

        public JournalEventService EventManager { get; }

        public EDSMJournalSync(string apiKey, string commandername, string applicationName, string applicationVersion)
        {
            this.apiKey = apiKey;
            this.commandername = commandername;
            this.applicationName = applicationName;
            this.applicationVersion = applicationVersion;

            EventManager = ServiceController.GetService<JournalEventService>();
            EventManager.PreEventCall += Events_PreEventCall;
        }

        private void Events_PreEventCall(string eventname, DateTime timestamp, string json)
        {
            lock (_queue)
            {
                _queue.Enqueue((eventname, json));
            }
        }

        protected override void OnStart()
        {
            Task.Run(() =>
            {
                while (Running || _queue.Count > 0)
                {
                    (string Eventname, string Json)? element = default((string, string)?);

                    lock (_queue)
                    {
                        if (_queue.Count > 0)
                        {
                            element = _queue.Dequeue();
                        }
                    }

                    if (!element.HasValue)
                    {
                        Thread.Sleep(2000);
                        continue;
                    }

                    if (string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(commandername))
                        continue;

                    if (DiscardEvents.AlwaysDiscard.Contains(element.Value.Eventname))
                        continue;

                    var list = new Dictionary<string, string>
                    {
                        { "commanderName", commandername },
                        { "apiKey", apiKey },
                        { "fromSoftware", applicationName },
                        { "fromSoftwareVersion", applicationVersion },
                        { "message", Uri.EscapeDataString(element.Value.Json) }
                    };


                    var request = WebRequest.Create("https://www.edsm.net/api-journal-v1");
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                    var writer = new StreamWriter(request.GetRequestStream());
                    writer.Write(string.Join("&", list.Select(m => $"{m.Key}={m.Value}")));
                    writer.Flush();

                    var requestjson = JsonConvert.DeserializeObject<dynamic>(element.Value.Json);

                    try
                    {
                        var response = (HttpWebResponse)request.GetResponse();

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            var reader = new StreamReader(response.GetResponseStream());
                            var responsejson = JsonConvert.DeserializeObject<dynamic>(reader.ReadToEnd());

                            var name = "";
                            if (!string.IsNullOrEmpty((string)requestjson.BodyName))
                            {
                                name = " '" + requestjson.BodyName + "'";
                            }
                            else if (!string.IsNullOrEmpty((string)requestjson.SystemName))
                            {
                                name = " '" + requestjson.SystemName + "'";
                            }
                            else if (!string.IsNullOrEmpty((string)requestjson.Name))
                            {
                                name = " '" + requestjson.Name + "'";
                            }
                            else if (!string.IsNullOrEmpty((string)requestjson.StarName))
                            {
                                name = " '" + requestjson.StarName + "'";
                            }
                            else if (!string.IsNullOrEmpty((string)requestjson.StarSystem))
                            {
                                name = " '" + requestjson.StarSystem + "'";
                            }
                            else if (!string.IsNullOrEmpty((string)requestjson.Power))
                            {
                                name = " '" + requestjson.Power + "'";
                            }
                            else if (!string.IsNullOrEmpty((string)requestjson.Commander))
                            {
                                name = " '" + requestjson.Commander + "'";
                            }
                            else
                            {

                            }

                            Debug.WriteLine($"Send EDSM {requestjson.@event}{name} {responsejson.msg}");
                        }
                        else
                        {
                            throw new Exception($"Error send EDSM {requestjson.@event}");
                        }
                    }
                    catch (Exception ex)
                    {

                        Debug.WriteLine(ex.Message);
                        _queue.Enqueue(element.Value);
                    }

                }
            });
        }
    }
}