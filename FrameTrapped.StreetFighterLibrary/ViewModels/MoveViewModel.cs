﻿namespace FrameTrapped.StreetFighterLibrary.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows;
    using Caliburn.Micro;
    using FrameTrapped.ComboTrainer.Messages;
    using FrameTrapped.ComboTrainer.ViewModels;
    using FrameTrapped.Input.Models;
    using FrameTrapped.Input.ViewModels;

    public class MoveViewModel
    {
        public enum MoveTypeEnum
        {
            Normal,
            Unique,
            Focus,
            RedFocus,
            Throw,
            Special,
            ExtraSpecial,
            Super,
            Ultra
        }

        private IEventAggregator _events;

        public string Name { get; private set; }

        public MoveTypeEnum MoveType { get; private set; }

        public string BlockType
        {
            get
            {
                return Hits.Distinct().First().BlockType.ToString();
            }
        }

        public string Damage
        {
            get
            {
                return
                    string.Join("*", Hits.Select(o => o.Damage).ToArray());
            }
        }

        public string Stun
        {
            get
            {
                return
                    string.Join("*", Hits.Select(o => o.Stun).ToArray());
            }
        }

        public string MeterGain
        {
            get
            {
                return
                    string.Join("*", Hits.Select(o => o.MeterGain).ToArray());
            }
        }

        public string CancelAbility
        {
            get
            {
                List<HitViewModel.CancelAbilityEnum> cancels = Hits.SelectMany(o => o.CancelAbility).ToList();
                return
                    string.Join("/", cancels.Distinct().Select(o => o.ToString().Substring(0, 2)));
            }
        }

        public string Startup
        {
            get
            {
                return Hits.First().Startup.ToString();
            }
        }

        public string Active
        {
            get
            {
                return Hits.First().Startup.ToString();
            }
        }

        public string Recovery
        {
            get
            {
                return Hits.Last().Recovery.ToString();
            }
        }

        public string OnBlockAdvantage
        {
            get
            {
                return Hits.Last().OnBlockAdvantage.ToString();
            }
        }

        public string OnHitAdvantage
        {
            get
            {
                return Hits.Last().OnHitAdvantage.ToString();
            }
        }

        public string Notes
        {
            get
            {
                return
                    string.Join(" ", Hits.Select(o => o.Notes).ToArray());
            }
        }

        public ObservableCollection<HitViewModel> Hits { get; private set; }

        public CommandViewModel Command { get; private set; }

        public void AddCommandToTimeline(object moveViewModel)
        {
            foreach (InputItemViewModel inputItem in Command.Commands)
            {
                TimeLineItemViewModel timeLineItemViewModel = new TimeLineItemViewModel();
                timeLineItemViewModel.InputItemViewModel = inputItem;
                _events.Publish(new AddTimeLineItemMessage(timeLineItemViewModel));
            }
        }

        public MoveViewModel(IEventAggregator events, string name, MoveTypeEnum moveType, ObservableCollection<HitViewModel> hits, CommandViewModel command)
        {
            _events = events;
            Name = name;
            MoveType = moveType;
            Hits = hits;
            Command = command;
        }
    }
}