using System;
using System.Collections.Generic;
using EliteEventAPI.Services.Journal;
using EliteEventAPI.Services.Journal.Events;

namespace EliteEventAPI.Services.Storage.Models
{
    public sealed class GameModel : ModelBase
    {
        private readonly Queue<ChatMessage> _messages = new Queue<ChatMessage>();
        private int _maxchatmasseges;

        public GameModel(JournalEventService eventservice)
        {
            MaxChatMessages = 50;
            eventservice.Subscribe<StatusEvent>(GameStatusCallback);
            eventservice.Subscribe<FileheaderEvent>(FileheaderCallback);
            eventservice.Subscribe<ReceiveTextEvent>(ReceiveTextCallback);
        }

        public string From { get; private set; }

        private void ReceiveTextCallback(ReceiveTextEvent obj)
        {
            var message = new ChatMessage()
            {
                Time = obj.Timestamp,
                Channel = (ChatChannel)Enum.Parse(typeof(ChatChannel), obj.Channel, true),
                Message = string.IsNullOrEmpty(obj.MessageLocalised) ? obj.Message : obj.MessageLocalised,
                From = string.IsNullOrEmpty(obj.FromLocalised) ? obj.From : obj.FromLocalised
            };

            _messages.Enqueue(message);
            OnAction("AddChatMessage");

            if (_messages.Count > MaxChatMessages)
            {
                _messages.Dequeue();
            }
        }

        private void FileheaderCallback(FileheaderEvent obj)
        {
            SetValue(() => Gameversion, obj.Gameversion);
            SetValue(() => Build, obj.Build);
            SetValue(() => Language, obj.Language);
            SetValue(() => Part, obj.Part);
        }

        private void GameStatusCallback(StatusEvent obj)
        {
            SetValue(() => GuiFocus, (GuiFocus)Enum.Parse(typeof(GuiFocus), obj.GuiFocus.ToString()));
            SetValue(() => Running, obj.IsRunning);
        }

        public GuiFocus GuiFocus { get => GetValue(() => GuiFocus); }

        public bool Running { get; private set; }

        public string Gameversion { get; private set; }

        public string Build { get; private set; }

        public string Language { get; private set; }

        public int Part { get; private set; }

        public int MaxChatMessages
        {
            get { return _maxchatmasseges; }
            set
            {
                _maxchatmasseges = value;
                AdjustMessageQueue();
            }
        }

        private void AdjustMessageQueue()
        {
            var todelete = _messages.Count - _maxchatmasseges;

            if (todelete > 0)
            {
                for (int i = 0; i < todelete; i++)
                {
                    _messages.Dequeue();
                }
            }
        }
    }
}