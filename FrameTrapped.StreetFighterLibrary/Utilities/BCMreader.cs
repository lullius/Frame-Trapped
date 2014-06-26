using FrameTrapped.StreetFighterLibrary.ViewModels;
using FrameTrapped.Input.ViewModels;
using FrameTrapped.Input.Models;
using Caliburn.Micro;


using RainbowLib;
using RainbowLib.BCM;
using RainbowLib.BAC;
using System.Collections.Generic;

namespace FrameTrapped.StreetFighterLibrary.Utilities
{
    static class BCMreader
    {

        static string sf4path = @"J:\Installerte Spill\Steam\steamapps\common\Super Street Fighter IV - Arcade Edition\";

        private static BCMFile bcm;
        private static BACFile bac;

        private static string loadedCharacter;

        public static void loadBCM(string character)
        {
            string path = sf4path + @"patch\battle\regulation\latest_ae\" + character + @"\" + character + @".bcm"; //This isn't case sensitive.
            bcm = BCMFile.FromFilename(path);
            bac = RainbowLib.BACFile.FromFilename(path.Replace("bcm", "bac"), bcm);
            loadedCharacter = character.ToLower();
        }

        private static BindableCollection<HitViewModel> getHits(Move move)
        {
            BindableCollection<HitViewModel> tmpHitList = new BindableCollection<HitViewModel>();
            HitViewModel.BlockTypeEnum tmpBlock = new HitViewModel.BlockTypeEnum();
            int damage = -1;
            int lateDamage = -1;
            int stun = -1;
            int latestun = -1;
            int meterGain = -1;
            HitViewModel.CancelAbilityEnum[] tmpCancel = new HitViewModel.CancelAbilityEnum[1];
            int startUp = -1;
            int active = -1;
            int recovery = -1;
            int onBlockAdvantage = -1;
            int onHitAdvantage = -1;
            string notes = "";

            try
            {
                List<HitViewModel.CancelAbilityEnum> cancelList = new List<HitViewModel.CancelAbilityEnum>();
                foreach (CancelCommand cancel in move.Script.CommandLists[(int)CommandListType.CANCELS]) //These aren't finished. More cancels exists. I'll add them as I go.
                {
                    notes += cancel.CancelList.ToString() + " ";  //This is just for debugging...
                    if (cancel.CancelList.ToString().Contains("SUPER MOVE"))
                        cancelList.Add(HitViewModel.CancelAbilityEnum.Special);
                    if (cancel.CancelList.ToString().Contains("SUPER COMBO"))
                        cancelList.Add(HitViewModel.CancelAbilityEnum.Super);
                    if (cancel.CancelList.ToString().Contains("SC"))
                        cancelList.Add(HitViewModel.CancelAbilityEnum.Super);
                    if (cancel.CancelList.ToString().Contains("UC"))
                        cancelList.Add(HitViewModel.CancelAbilityEnum.Ultra);
                    if (cancel.CancelList.ToString().Contains("SAVING"))
                        cancelList.Add(HitViewModel.CancelAbilityEnum.Dash);
                    if (cancel.CancelList.ToString().Contains("CANCEL_"))
                        cancelList.Add(HitViewModel.CancelAbilityEnum.Chain);
                }
                tmpCancel = cancelList.ToArray();
            }
            catch { }


            try
            {
                foreach (HitboxCommand hitbox in move.Script.CommandLists[(int)CommandListType.HITBOX])
                {
                    if (hitbox.Type != HitboxCommand.HitboxType.PROXIMITY) //Exclude proximity boxes
                    {
                        switch (hitbox.HitLevel)
                        {
                            case HitboxCommand.HitLevelType.UNBLOCKABLE:
                                tmpBlock = HitViewModel.BlockTypeEnum.Unblockable;
                                break;
                            case HitboxCommand.HitLevelType.OVERHEAD:
                                tmpBlock = HitViewModel.BlockTypeEnum.High;
                                break;
                            case HitboxCommand.HitLevelType.MID:
                                tmpBlock = HitViewModel.BlockTypeEnum.Mid;
                                break;
                            case HitboxCommand.HitLevelType.LOW:
                                tmpBlock = HitViewModel.BlockTypeEnum.Low;
                                break;

                            default:
                                tmpBlock = HitViewModel.BlockTypeEnum.Mid;
                                break;
                        }

                        startUp = hitbox.StartFrame - 1;
                        active = hitbox.EndFrame - hitbox.StartFrame;
                        tmpHitList.Add(new HitViewModel(tmpBlock, damage, lateDamage, stun, latestun, meterGain, tmpCancel, startUp, active, recovery, onBlockAdvantage, onHitAdvantage, notes)); //Info loaded here is mostly wrong or missing. Notes are currently used for debugging/getting info.
                    }
                }
            }

            catch { }
            return tmpHitList;
        }

        private static InputItemViewModel getCommands(string commands)
        {
            InputItemViewModel viewModel = new InputItemViewModel();
            viewModel.Light_Punch = commands.Contains("LP");
            viewModel.Medium_Punch = commands.Contains("MP");
            viewModel.Hard_Punch = commands.Contains("HP");

            viewModel.Light_Kick = commands.Contains("LK");
            viewModel.Medium_Kick = commands.Contains("MK");
            viewModel.Hard_Kick = commands.Contains("HK");

            if (commands.Contains("UP, FORWARD"))
                 viewModel.Direction = InputCommandModel.DirectionStateEnum.UpForward;
            else if (commands.Contains("UP, BACK"))
                viewModel.Direction = InputCommandModel.DirectionStateEnum.UpBack;
            else if (commands.Contains("DOWN, FORWARD"))
                viewModel.Direction = InputCommandModel.DirectionStateEnum.DownForward;
            else if (commands.Contains("DOWN, BACK"))
                viewModel.Direction= InputCommandModel.DirectionStateEnum.DownBack;
            else if (commands.Contains("FORWARD"))
                viewModel.Direction = InputCommandModel.DirectionStateEnum.Forward;
            else if (commands.Contains("BACK"))
                viewModel.Direction = InputCommandModel.DirectionStateEnum.Back;
            else if (commands.Contains("UP"))
                viewModel.Direction = InputCommandModel.DirectionStateEnum.Up;
            else if (commands.Contains("DOWN"))
                viewModel.Direction = InputCommandModel.DirectionStateEnum.Down;
            else
            {
                viewModel.Direction = InputCommandModel.DirectionStateEnum.Neutral;
            }

            return viewModel;
        }

        private static InputItemViewModel getMotion(InputMotionEntry motion) //For some reason 360's and 720's won't work with this. They have no "motion" in the bcm.
        {
            switch (motion.DirectionName.ToString())
            { 
                case "DOWN":
                    return new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down };
                case "FORWARD":
                    return new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward };
                case "BACK":
                    return new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back };
                case "UP":
                    return new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Up };

                case "DOWN, BACK":
                    return new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack };
                case "DOWN, FORWARD":
                    return new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward };
                case "UP, FORWARD":
                    return new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.UpForward };
                case "UP, BACK":
                    return new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.UpBack };

                case "NEUTRAL":
                    return new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Neutral };

                default:
                    return null;    
            }
        }

        public static MoveListViewModel getInputs()
        {
            CommandViewModel tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>());
            BindableCollection<HitViewModel> tmpHitList = new BindableCollection<HitViewModel>();
            MoveListViewModel moveList = new MoveListViewModel();

            foreach (Move move in bcm.Moves)
            {
                tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>());
                tmpHitList = new BindableCollection<HitViewModel>();

                if (move.InputMotion.Name != "NONE")
                {
                    foreach (InputMotionEntry motion in move.InputMotion.Entries)
                    {
                        tmpCommand.Commands.Add(BCMreader.getMotion(motion));
                    }
                }

                if (move.Input.ToString() != "NONE")
                {
                    tmpCommand.Commands.Add(getCommands(move.Input.ToString())); //This sets both the direction and button on moves that have no motion
                }

                tmpHitList = getHits(move);   
                
                if (getMoveName(move) != "")
                    moveList.Add(new MoveViewModel(FighterDataAE2012.Events, getMoveName(move), MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));
                else
                    moveList.Add(new MoveViewModel(FighterDataAE2012.Events, move.Name, MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));
            }
            return moveList;
        }


        private static string getNotes(Move move) //These are just test notes.
        {
            string notes = "";

            if (loadedCharacter == "ryu" && move.Name == "BACK_DASH")
            {
                notes += "This is Ryu's backdash ";
            }

            if (move.StateRestriction.ToString().Contains("AIR"))
            {
                notes += "Air OK ";
            }

            if (move.InputMotion.Name.ToString() == "SCREW")
            {
                notes += "360 ";
            }

            if (move.InputMotion.Name.ToString() == "SC_SCREW")
            {
                notes += "720 ";
            }

            return notes;  
        }

        private static string getMoveName(Move move)
        {

        string moveName = "";

        if (move.Name.Contains("8"))
        {
        moveName += "Neutral Jump "; 
        }

        else if (move.Name.Contains("7"))
        {
        moveName += "Back Jump "; 
        }

        else if (move.Name.Contains("9"))
        {
        moveName += "Forward Jump "; 
        }
        
        else if (move.Name.Contains("5"))
        {
        moveName += "Neutral "; 
        }

        else if (move.Name.Contains("4"))
        {
        moveName += "Back "; 
        }

        else if (move.Name.Contains("6"))
        {
        moveName += "Forward "; 
        }

        else if (move.Name.Contains("2"))
        {
        moveName += "Down "; 
        }

        else if (move.Name.Contains("1"))
        {
        moveName += "Down Back "; 
        }

        else if (move.Name.Contains("3"))
        {
        moveName += "Down Forward "; 
        }
        else
        {
            return "";
        }



        if (move.Name.Contains("LP"))
        {
        moveName += "Light Punch"; 
        }
        else if (move.Name.Contains("MP"))
        {
            moveName += "Medium Punch";
        }
        else if (move.Name.Contains("HP"))
        {
            moveName += "Hard Punch";
        }

        else if (move.Name.Contains("LK"))
        {
            moveName += "Light Kick";
        }
        else if (move.Name.Contains("MK"))
        {
            moveName += "Medium Kick";
        }
        else if (move.Name.Contains("HK"))
        {
            moveName += "Hard Kick";
        }
        else
        {
            return "";
        }
            return moveName;
        }
    }
}
