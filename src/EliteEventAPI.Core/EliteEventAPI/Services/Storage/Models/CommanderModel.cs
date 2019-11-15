using EliteEventAPI.Services.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI.Services.Storage.Models
{
    public sealed class CommanderModel : ModelBase
    {
        public CommanderModel(EventService eventservice)
        {
            eventservice.Subscribe<CommanderEvent>(CallbackCommanderEvent);
        }

        private void CallbackCommanderEvent(CommanderEvent obj)
        {
            SetValue(() => Name, obj.Name);
            SetValue(() => FID, obj.FID);
        }

        public string Name { get => GetValue(() => FID); }

        public string FID { get => GetValue(() => FID); }
    }
}