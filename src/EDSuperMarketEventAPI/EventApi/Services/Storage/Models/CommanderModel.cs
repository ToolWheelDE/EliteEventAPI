using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal;
using ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage.Models
{
    public sealed class CommanderModel : ModelBase
    {
        public CommanderModel(JournalEventService eventservice)
        {
            eventservice.Subscribe<CommanderEvent>(CallbackCommanderEvent);
            eventservice.Subscribe<RankEvent>(CallbackRankEvent);
            eventservice.Subscribe<ProgressEvent>(CallbackProgressEvent);
        }

        private void CallbackProgressEvent(ProgressEvent obj)
        {
            SetValue(() => Rank.Combat, obj.Combat);
            SetValue(() => Rank.Trade, obj.Trade);
            SetValue(() => Rank.Explore, obj.Explore);
            SetValue(() => Rank.Soldier, obj.Soldier);
            SetValue(() => Rank.Exobiologist, obj.Exobiologist);
            SetValue(() => Rank.Empire, obj.Empire);
            SetValue(() => Rank.Federation, obj.Federation);
            SetValue(() => Rank.Cqc, obj.Cqc);
        }

        private void CallbackRankEvent(RankEvent obj)
        {
            SetValue(() => ProgressRank.Combat, obj.Combat);
            SetValue(() => ProgressRank.Trade, obj.Trade);
            SetValue(() => ProgressRank.Explore, obj.Explore);
            SetValue(() => ProgressRank.Soldier, obj.Soldier);
            SetValue(() => ProgressRank.Exobiologist, obj.Exobiologist);
            SetValue(() => ProgressRank.Empire, obj.Empire);
            SetValue(() => ProgressRank.Federation, obj.Federation);
            SetValue(() => ProgressRank.Cqc, obj.Cqc);
        }

        private void CallbackCommanderEvent(CommanderEvent obj)
        {
            SetValue(() => Name, obj.Name);
            SetValue(() => FID, obj.FID);
        }

        public string Name { get => GetValue(() => FID); }

        public string FID { get => GetValue(() => FID); }

        public CommanderProgressDetails Rank { get; }

        public CommanderProgressDetails ProgressRank { get; }
    }
}