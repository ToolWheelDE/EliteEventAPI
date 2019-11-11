using EliteEventAPI.Configuration;
using EliteEventAPI.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace EliteEventAPI.Services
{
    public sealed class EDSMJournalSync : ServiceBase
    {
        private readonly Queue<(string, string)> _queue = new Queue<(string, string)>();

        private static readonly HashSet<string> alwaysDiscard = new HashSet<string> {  "AfmuRepairs",
    "ApproachBody",
    "Bounty",
    "CapShipBond",
    "ChangeCrewRole",
    "ClearSavedGame",
    "CockpitBreached",
    "Commander",
    "Continued",
    "Coriolis",
    "CrewAssign",
    "CrewFire",
    "CrewLaunchFighter",
    "CrewMemberJoins",
    "CrewMemberQuits",
    "CrewMemberRoleChange",
    "DataScanned",
    "DatalinkScan",
    "DatalinkVoucher",
    "DiscoveryScan",
    "DockFighter",
    "DockSRV",
    "DockingCancelled",
    "DockingDenied",
    "DockingGranted",
    "DockingRequested",
    "DockingTimeout",
    "EDDCommodityPrices",
    "EDDItemSet",
    "EDShipyard",
    "EndCrewSession",
    "EngineerApply",
    "EngineerLegacyConvert",
    "EscapeInterdiction",
    "FSSSignalDiscovered",
    "FactionKillBond",
    "FighterDestroyed",
    "FighterRebuilt",
    "Fileheader",
    "FuelScoop",
    "HeatDamage",
    "HeatWarning",
    "HullDamage",
    "JetConeBoost",
    "JetConeDamage",
    "KickCrewMember",
    "LaunchDrone",
    "LaunchFighter",
    "LaunchSRV",
    "LeaveBody",
    "Liftoff",
    "Market",
    "MassModuleStore",
    "MaterialDiscovered",
    "ModuleArrived",
    "ModuleInfo",
    "ModuleStore",
    "ModuleSwap",
    "Music",
    "NavBeaconScan",
    "NewCommander",
    "NpcCrewRank",
    "Outfitting",
    "Passengers",
    "PowerplayVote",
    "PowerplayVoucher",
    "RebootRepair",
    "ReceiveText",
    "RepairDrone",
    "ReservoirReplenished",
    "SRVDestroyed",
    "Scanned",
    "Screenshot",
    "SendText",
    "ShieldState",
    "ShipArrived",
    "ShipTargeted",
    "Shipyard",
    "ShipyardNew",
    "ShutDown",
    "Shutdown",
    "StartJump",
    "Status",
    "StoredModules",
    "SupercruiseEntry",
    "SupercruiseExit",
    "SystemsShutdown",
    "Touchdown",
    "UnderAttack",
    "VehicleSwitch",
    "WingAdd",
    "WingInvite",
    "WingJoin",
    "WingLeave" };

        private EDSMSyncConfiguration _configuration;

        public override string Name => "EDSM Sync Service";

        public EventService EventManager { get; }

        public EDSMJournalSync()
        {
            _configuration = ConfigurationManager.LoadConfiguration<EDSMSyncConfiguration>();

            EventManager = ServiceController.GetService<EventService>();
            EventManager.PreEventCall += Events_PreEventCall;
        }

        private void Events_PreEventCall(string eventname, string json)
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
                    (string Eventname, string Json)? element = default((string, string));

                    lock (_queue)
                    {
                        if (_queue.Count > 0)
                        {
                            element = _queue.Dequeue();
                        }
                    }

                    if (!element.HasValue)
                    {
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (string.IsNullOrWhiteSpace(_configuration.APIKey) || string.IsNullOrWhiteSpace(_configuration.Commandname))
                        continue;

                    if (alwaysDiscard.Contains(element.Value.Eventname))
                        continue;

                    var list = new Dictionary<string, string>
                    {
                        { "commanderName", _configuration.Commandname },
                        { "apiKey", _configuration.APIKey },
                        { "fromSoftware", "EliteEventAPIEDSMSync" },
                        { "fromSoftwareVersion", "1.0" },
                        { "message", Uri.EscapeDataString(element.Value.Json) }
                    };


                    var request = HttpWebRequest.Create("https://www.edsm.net/api-journal-v1");
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

                            Trace.TraceInformation($"Send EDSM {requestjson.@event}{name} {responsejson.msg}");
                        }
                        else
                        {
                            Trace.TraceWarning($"Error send EDSM {requestjson.@event}");
                        }
                    }
                    catch (Exception ex)
                    {
                        lock (_queue)
                        {
                            Trace.TraceError(ex.Message);
                            _queue.Enqueue(element.Value);
                        }
                    }
                }
            });
        }
    }
}
