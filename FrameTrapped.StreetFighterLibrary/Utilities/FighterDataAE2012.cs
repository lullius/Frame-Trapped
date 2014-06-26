namespace FrameTrapped.StreetFighterLibrary.Utilities
{
    using System.Collections.ObjectModel;

    using Caliburn.Micro;

    using FrameTrapped.StreetFighterLibrary.ViewModels;
    using FrameTrapped.Input.ViewModels;
    using FrameTrapped.Input.Models;
    
    public static class FighterDataAE2012
    {
        public static IEventAggregator Events;
 
        public static FighterViewModel Ryu()
        {
            BindableCollection<HitViewModel> tmpHitList;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();

            // Close Punches
            // Close Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 3, 6, 2, 5, ""));

            moveList.Add(new MoveViewModel(Events, "Close Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 3, 21, -3, 3, ""));

            moveList.Add(new MoveViewModel(Events, "Close Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 80, 200, 150, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 7, 26, -15, -10, "Forces stand, less damage and stun on 3~5f"));

            moveList.Add(new MoveViewModel(Events, "Close Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Kicks
            // Close Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 5, 7, -1, 2, ""));

            moveList.Add(new MoveViewModel(Events, "Close Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 5, 16, -7, -2, ""));

            moveList.Add(new MoveViewModel(Events, "Close Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 125, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Super }, 8, 8, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 75, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 2, 4, 15, -1, 4, ""));

            moveList.Add(new MoveViewModel(Events, "Close Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Punches

            // Far Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 3, 6, 2, 5, ""));

            moveList.Add(new MoveViewModel(Events, "Far Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 4, 14, -4, -1, ""));

            moveList.Add(new MoveViewModel(Events, "Far Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 120, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 8, 3, 15, 0, -4, ""));

            moveList.Add(new MoveViewModel(Events, "Far Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Kicks

            // Far Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 6, 6, -1, 2, ""));

            moveList.Add(new MoveViewModel(Events, "Far Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 8, 2, 17, -5, -2, ""));

            moveList.Add(new MoveViewModel(Events, "Far Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 110, 0, 125, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 9, 4, 20, -6, -2, ""));

            moveList.Add(new MoveViewModel(Events, "Far Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Punches

            // Crouch Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 2, 7, 2, 5, ""));

            moveList.Add(new MoveViewModel(Events, "Crouch Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 60, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 4, 8, 2, 5, ""));

            moveList.Add(new MoveViewModel(Events, "Crouch Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 90, 0, 200, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 8, 28, -18, -13, "Forces stand"));

            moveList.Add(new MoveViewModel(Events, "Crouch Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Kicks

            // Crouch Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 20, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 3, 9, -1, 2, ""));

            moveList.Add(new MoveViewModel(Events, "Crouch Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 60, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 5, 12, -3, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Crouch Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 90, 0, 100, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 5, 4, 28, -14, 0, "Untechable knockdown"));

            moveList.Add(new MoveViewModel(Events, "Crouch Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Punches

            // Neutral Jump Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 10, 7, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 5, 5, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 6, 5, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Kicks

            // Neutral Jump Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 9, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 6, 10, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 200, 0, 100, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 4, 4, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Punches

            // Angled Jump Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 4, 7, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 50, 0, 50, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 7, 3, 0, 0, 0, "Legs projectile invincible until end of startup frames, [1st Air hit] floats opponent,"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 30, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 0, 4, 0, 0, 0, "[2nd Air hit] knock down and can juggle"));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 6, 5, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Kicks

            // Angled Jump Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 4, 8, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 6, 6, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 200, 0, 100, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 7, 7, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            #region Unique Punches

            // Collarbone Breaker
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Forward, Medium_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 17, 1, 0, 1, 1, "Overhead attack"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 1, 2, 14, -2, 3, ""));

            moveList.Add(new MoveViewModel(Events, "Collarbone Breaker", MoveViewModel.MoveTypeEnum.Unique, tmpHitList, tmpCommand));

            // Solar Plexus Strike
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Forward, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 17, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 0, 2, 18, 0, 4, ""));

            moveList.Add(new MoveViewModel(Events, "Solar Plexus Strike", MoveViewModel.MoveTypeEnum.Unique, tmpHitList, tmpCommand));

            #endregion

            #region Focus Attacks

            // Focus Attack Level 1
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Medium_Punch = true, Medium_Kick = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 21, 2, 35, -21, -21, ""));

            moveList.Add(new MoveViewModel(Events, "Focus Attack Level 1", MoveViewModel.MoveTypeEnum.Focus, tmpHitList, tmpCommand));

            // Focus Attack Level 2
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true, Medium_Kick = true, WaitFrames = 17 }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 150, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 17, 2, 35, -15, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Focus Attack Level 2", MoveViewModel.MoveTypeEnum.Focus, tmpHitList, tmpCommand));

            // Focus Attack Level 3
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true, Medium_Kick = true, WaitFrames = 65 }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Unblockable, 140, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 65, 2, 35, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Focus Attack Level 3", MoveViewModel.MoveTypeEnum.Focus, tmpHitList, tmpCommand));

            #endregion

            #region Throw Attacks

            // Forward Throw
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Light_Punch = true, Light_Kick = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Techable, 130, 0, 140, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 3, 2, 20, 0, 0, "Untechable knockdown, Range 0.9 Units"));

            moveList.Add(new MoveViewModel(Events, "Forward Throw", MoveViewModel.MoveTypeEnum.Throw, tmpHitList, tmpCommand));

            // Backward Throw
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back, Light_Punch = true, Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Techable, 130, 0, 120, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 3, 2, 20, 0, 0, "Untechable knockdown, Range 0.9 Units"));

            moveList.Add(new MoveViewModel(Events, "Backward Throw", MoveViewModel.MoveTypeEnum.Throw, tmpHitList, tmpCommand));
          
            #endregion

            // Special Attacks

            #region Hadokens
            // Light Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 10, new[] { HitViewModel.CancelAbilityEnum.Super }, 13, 0, 45, -6, -2, "[Air hit] knock down, 16~17f focus cancellable without hit"));

            moveList.Add(new MoveViewModel(Events, "Light Hadoken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Medium Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 10, new[] { HitViewModel.CancelAbilityEnum.Super }, 13, 0, 45, -6, -2, "[Air hit] knock down, 16~17f focus cancellable without hit"));

            moveList.Add(new MoveViewModel(Events, "Medium Hadoken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Hard Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 10, new[] { HitViewModel.CancelAbilityEnum.Super }, 13, 0, 45, -6, -2, "[Air hit] knock down, 16~17f focus cancellable without hit"));

            moveList.Add(new MoveViewModel(Events, "Hard Hadoken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // EX Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Light_Punch = true, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, -250, new[] { HitViewModel.CancelAbilityEnum.Super }, 12, 0, 45, 0, 0, "Knock down, can juggle, [counterhit] floats opponent, 15~16f focus cancellable"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 0, new[] { HitViewModel.CancelAbilityEnum.Super }, 0, 0, 50, 1, 0, ""));

            moveList.Add(new MoveViewModel(Events, "EX Hadoken", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));

            #endregion

            #region Shoryukens

            // Light Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward, Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 70, 200, 200, 30, new[] { HitViewModel.CancelAbilityEnum.Super }, 3, 14, 24, -17, 0, "1~2f Invincible, 3~4f unthrowable, 3~16f lower body invincibility, 4f~ airborne, knock down, [] refers to active frames 3~14f"));

            moveList.Add(new MoveViewModel(Events, "Light Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Medium Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {  
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 150, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Super }, 3, 2, 0, 0, 0, "1~5f Invincible, 6~16f lower body invincibility, 5f~ airborne, knock down, "));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 0, 12, 43, -34, 0, "[2nd hit] can juggle"));

            moveList.Add(new MoveViewModel(Events, "Medium Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Hard Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {  
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 160, 60, 200, 50, 20, new HitViewModel.CancelAbilityEnum[] { }, 3, 14, 46, -37, 0, "1~4f Invincible, 3~4f unthrowable, 5~16f lower body invincibility, 3f~ airborne, knock down, [] refers to active frames 3~14f"));

            moveList.Add(new MoveViewModel(Events, "Hard Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // EX Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward,  Light_Punch = true, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, -250, new[] { HitViewModel.CancelAbilityEnum.Super }, 3, 2, 45, 0, 0, "1~16f Invincible, 6f~ airborne, knock down, "));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 0, new[] { HitViewModel.CancelAbilityEnum.Super }, 0, 12, 48, -39, 0, "[2nd hit] can juggle"));

            moveList.Add(new MoveViewModel(Events, "EX Shoryuken", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));

            #endregion

            #region Tatsumaki Senpukyakus

            // Light Tatsumaki Senpukyaku
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, -250, new[] { HitViewModel.CancelAbilityEnum.Super }, 3, 2, 45, 0, 0, "1~16f Invincible, 6f~ airborne, knock down, "));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 0, new[] { HitViewModel.CancelAbilityEnum.Super }, 0, 12, 48, -39, 0, "[2nd hit] can juggle"));

            moveList.Add(new MoveViewModel(Events, "Light Tatsumaki Senpukyaku", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Medium Tatsumaki Senpukyaku
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 110, 0, 110, 0, 30, new HitViewModel.CancelAbilityEnum[] { }, 12, 2, 0, 0, 0, "7~45f lower body immune to projectiles, 7f~ airborne, knock down, armor break, cannot hit crouching opponents."));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 0, 0, 0, "[2nd hit] aimed backwards"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 0, 0, 0, "[3rd hit] aimed backwards"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 0, 0, 0, "[4th hit] aimed backwards"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 21, -2, 0, ""));
            
            moveList.Add(new MoveViewModel(Events, "Medium Tatsumaki Senpukyaku", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Hard Tatsumaki Senpukyaku
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 120, 0, 200, 0, 30, new HitViewModel.CancelAbilityEnum[] { }, 12, 2, 0, 0, 0, "7~45f lower body immune to projectiles, 7f~ airborne, knock down, armor break, cannot hit crouching opponents."));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 0, 0, 0, "[2nd hit] aimed backwards"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 0, 0, 0, "[3rd hit] aimed backwards"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 0, 0, 0, "[4th hit] aimed backwards"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 21, -2, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Hard Tatsumaki Senpukyaku", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // EX Tatsumaki Senpukyaku
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back, Light_Kick = true, Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, -250, new HitViewModel.CancelAbilityEnum[] { }, 11, 1, 0, 0, 0, "6~27f lower body immune to projectiles, 6f~ airborne, forces stand."));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 0, 0, 0, "[2nd hit] forces stand, aimed backwards"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 0, 0, 0, "[3rd hit] forces stand, aimed backwards"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 0, 0, 0, "[4th hit] forces stand, aimed backwards"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 21, -1, 0, "[5th hit] knock down, armor break, can juggle"));

            moveList.Add(new MoveViewModel(Events, "EX Tatsumaki Senpukyaku", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));
            
            // AIR
            // Light Tatsumaki Senpukyaku (Air)
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 9, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 10, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Light Tatsumaki Senpukyaku (Air)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Medium Tatsumaki Senpukyaku (Air)
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 30, new HitViewModel.CancelAbilityEnum[] { }, 9, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 10, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Medium Tatsumaki Senpukyaku (Air)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Hard Tatsumaki Senpukyaku (Air)
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 90, 0, 100, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 9, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 10, 0, 0, ""));
            
            moveList.Add(new MoveViewModel(Events, "Hard Tatsumaki Senpukyaku (Air)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // EX Tatsumaki Senpukyaku (Air)
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back, Light_Kick = true, Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, -250, new HitViewModel.CancelAbilityEnum[] { }, 7, 1, 0, 0, 0, "Four hits pursuit property"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 4, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "EX Tatsumaki Senpukyaku (Air)", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));
            #endregion

            #region Shinkuu Hadouken
            // Shinkuu Hadouken

            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward,},
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward,},
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, -1000, new HitViewModel.CancelAbilityEnum[] { }, 3, 0, 0, 0, 0, "1f invincible, Pursuit property."));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 10, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 52, 11, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Shinkuu Hadouken (Slow)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward,},
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward,},
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, -1000, new HitViewModel.CancelAbilityEnum[] { }, 3, 0, 0, 0, 0, "1f invincible, Pursuit property."));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 10, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 52, 11, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Shinkuu Hadouken (Normal)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward,},
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward,},
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, -1000, new HitViewModel.CancelAbilityEnum[] { }, 3, 0, 0, 0, 0, "1f invincible, Pursuit property."));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 10, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 52, 11, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Shinkuu Hadouken (Fast)", MoveViewModel.MoveTypeEnum.Super, tmpHitList, tmpCommand));
            #endregion

            #region Metsu Hadouken & Metsu Shoryuken

            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Light_Punch = true, Medium_Punch = true, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 42, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 11, 0, 0, 0, 0, "1~9f Invincible"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 42, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 42, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 42, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 42, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 42, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 42, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 75, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 120, -25, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Metsu Hadouken", MoveViewModel.MoveTypeEnum.Ultra, tmpHitList, tmpCommand));

            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Light_Kick = true, Medium_Kick = true, Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 270, 270, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 8, 3, 0, 0, 0, "1~10f Invincible, 11~f airborne"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 38, 233, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 3, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 38, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 3, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 38, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 3, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 38, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 3, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 3, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 3, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 3, 84, -84, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Metsu Shoryuken", MoveViewModel.MoveTypeEnum.Ultra, tmpHitList, tmpCommand));

            #endregion

            // Initialise Ryu:
            FighterViewModel ryuFighter = new FighterViewModel("Ryu", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return ryuFighter;
        }

        public static FighterViewModel Ken()
        {
            BindableCollection<HitViewModel> tmpHitList;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();

            #region Normals
            // Close Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Light_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 2, 5, 4, 7, ""));

            moveList.Add(new MoveViewModel(Events, "Close Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 6, 3, 18, -7, -2, ""));

            moveList.Add(new MoveViewModel(Events, "Close Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                 new InputItemViewModel() { Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 90, 0, 150, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 6, 3, 19, -4, 1, "Forces stand"));

            moveList.Add(new MoveViewModel(Events, "Close Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 6, 2, 7, 2, 5, ""));

            moveList.Add(new MoveViewModel(Events, "Close Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 8, 3, 12, -1, 7, "Forces stand"));

            moveList.Add(new MoveViewModel(Events, "Close Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 110, 0, 200, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 8, 3, 21, -6, -2, ""));

            moveList.Add(new MoveViewModel(Events, "Close Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Punches

            // Far Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 20, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 2, 5, 4, 7, ""));

            moveList.Add(new MoveViewModel(Events, "Far Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Super }, 7, 5, 5, 4, 7, ""));

            moveList.Add(new MoveViewModel(Events, "Far Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 11, 3, 16, -1, 3, ""));

            moveList.Add(new MoveViewModel(Events, "Far Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Kicks

            // Far Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 4, 3, 7, 1, 4, ""));

            moveList.Add(new MoveViewModel(Events, "Far Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 7, 3, 13, -2, 1, ""));

            moveList.Add(new MoveViewModel(Events, "Far Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 130, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 11, 3, 18, -3, 1, ""));

            moveList.Add(new MoveViewModel(Events, "Far Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Punches

            // Crouch Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 3, 6, 2, 5, ""));

            moveList.Add(new MoveViewModel(Events, "Crouch Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 5, 8, 1, 4, ""));

            moveList.Add(new MoveViewModel(Events, "Crouch Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 0, 200, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 5, 22, -9, -4, "Forces stand"));

            moveList.Add(new MoveViewModel(Events, "Crouch Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Kicks

            // Crouch Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 20, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 4, 7, 0, 3, ""));

            moveList.Add(new MoveViewModel(Events, "Crouch Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 60, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 2, 16, -4, -1, ""));

            moveList.Add(new MoveViewModel(Events, "Crouch Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 100, 0, 100, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 8, 3, 21, -6, 0, "Hard knockdown"));

            moveList.Add(new MoveViewModel(Events, "Crouch Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Punches

            // Neutral Jump Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 7, 9, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 5, 4, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 7, 4, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Kicks

            // Neutral Jump Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 7, 10, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 6, 7, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, WaitFrames = 10},
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Neutral Jump Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Punches

            // Angled Jump Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 7, 8, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 70, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 5, 6, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 5, 4, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Kicks

            // Angled Jump Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 7, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 6, 4, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, WaitFrames = 10},
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 5, 7, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Angled Jump Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));


            // Unique kicks

            // Inazuma Kick
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Forward, Medium_Kick = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 15, 2, 17, -5, -2, ""));

            moveList.Add(new MoveViewModel(Events, "Inazuma Kick", MoveViewModel.MoveTypeEnum.Unique, tmpHitList, tmpCommand));

            // Step Kick
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Forward, Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 11, 5, 11, -2, 1, ""));

            moveList.Add(new MoveViewModel(Events, "Step Kick", MoveViewModel.MoveTypeEnum.Unique, tmpHitList, tmpCommand));

            // Thunder Kick
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Forward, Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 120, 0, 150, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 21, 2, 20, -4, -1, "Feint lasts 24f"));

            moveList.Add(new MoveViewModel(Events, "Thunder kick", MoveViewModel.MoveTypeEnum.Unique, tmpHitList, tmpCommand));
            #endregion

            #region Target Combo

            // Target Combo
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Medium_Punch = true, WaitFrames = 5},
                new InputItemViewModel() { Hard_Punch = true }
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 50, 0, 30, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 6, 3, 24, -9, -4, "Forces Stand"));

            moveList.Add(new MoveViewModel(Events, "Target Combo 1", MoveViewModel.MoveTypeEnum.Unique, tmpHitList, tmpCommand));

            #endregion

            #region Focus Attacks
            // Focus Attacks
            // Frame data needs to be confirmed.

            // Focus Attack Level 1
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Medium_Punch = true, Medium_Kick = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 22, 2, 42, -28, -28, ""));

            moveList.Add(new MoveViewModel(Events, "Focus Attack Level 1", MoveViewModel.MoveTypeEnum.Focus, tmpHitList, tmpCommand));

            // Focus Attack Level 2
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true, Medium_Kick = true, WaitFrames = 30 }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 90, 0, 150, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 30, 2, 42, -22, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Focus Attack Level 2", MoveViewModel.MoveTypeEnum.Focus, tmpHitList, tmpCommand));

            // Focus Attack Level 3
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true, Medium_Kick = true, WaitFrames = 68 }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Unblockable, 150, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 68, 2, 42, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Focus Attack Level 3", MoveViewModel.MoveTypeEnum.Focus, tmpHitList, tmpCommand));
            #endregion

            #region Throw Attacks
            // Throw Attacks

            // Forward Throw
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Light_Punch = true, Light_Kick = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Techable, 120, 0, 80, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 3, 2, 20, 0, 0, "Hard knockdown, Range 0.92 units"));

            moveList.Add(new MoveViewModel(Events, "Forward Throw", MoveViewModel.MoveTypeEnum.Throw, tmpHitList, tmpCommand));

            // Backward Throw
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back, Light_Punch = true, Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Techable, 130, 0, 130, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 3, 2, 20, 0, 0, "Hard knockdown, Range 0.92 units"));

            moveList.Add(new MoveViewModel(Events, "Backward Throw", MoveViewModel.MoveTypeEnum.Throw, tmpHitList, tmpCommand));

            #endregion

            // Special Attacks

            #region Hadouken
            // Light Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 10, new[] { HitViewModel.CancelAbilityEnum.Super }, 14, 0, 47, -7, -3, "Slowest speed. 17~18f cancellable"));

            moveList.Add(new MoveViewModel(Events, "Light Hadoken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Medium Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 10, new[] { HitViewModel.CancelAbilityEnum.Super }, 14, 0, 47, -7, -3, "Medium speed. 17~18f cancellable"));

            moveList.Add(new MoveViewModel(Events, "Medium Hadoken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Hard Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 10, new[] { HitViewModel.CancelAbilityEnum.Super }, 14, 0, 47, -7, -3, "Fastest speed. 17~18f cancellable"));

            moveList.Add(new MoveViewModel(Events, "Hard Hadoken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // EX Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Light_Punch = true, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, -250, new[] { HitViewModel.CancelAbilityEnum.Super }, 12, 0, 0, 0, 0, "17~18f cancellable, can juggle"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 0, new[] { HitViewModel.CancelAbilityEnum.Super }, 0, 0, 43, 0, 3, ""));

            moveList.Add(new MoveViewModel(Events, "EX Hadoken", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));
            #endregion

            #region Shoryuken
            // Light Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward, Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 120, 80, 100, 0, 30, new[] { HitViewModel.CancelAbilityEnum.Super }, 3, 11, 26, -20, 0, "1~3f invincible, 4~6f cannot be thrown"));

            moveList.Add(new MoveViewModel(Events, "Light Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Medium Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {  
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 90, 0, 120, 0, 30, new[] { HitViewModel.CancelAbilityEnum.Super }, 4, 3, 29, 0, 0, "1~6f invincible, 7~17f lower body invincibility, Pursuit Property, 1st hit cancellable"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 75, 0, 16, new HitViewModel.CancelAbilityEnum[] { }, 0, 11, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Medium Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Hard Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {  
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 30, new[] { HitViewModel.CancelAbilityEnum.Super }, 3, 2, 39, -30, 0, "1~4f invincible, 5~6f cannot be thrown, 5~18 lower body invincibility, Pursuit Property, 1st-2nd hit cancellable,"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 10, new[] { HitViewModel.CancelAbilityEnum.Super }, 0, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 0, 12, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Hard Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // EX Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward,  Light_Punch = true, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, -250, new[] { HitViewModel.CancelAbilityEnum.Super }, 4, 2, 54, -41, 0, "1~11f invincible, 12-18f lower body invincibility, Pursuit Property, 1st-2nd hit cancellable"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 25, 0, 0, new[] { HitViewModel.CancelAbilityEnum.Super }, 0, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 25, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 80, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 6, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "EX Shoryuken", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));

            #endregion

            #region Tatsumaki Senpukyaku
            // Light Tatsumaki Senpukyaku
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 70, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Super }, 6, 1, 0, 0, 0, "7~20f , 1st hit forces stand, Pursuit Property, 1st hit cancellable, Armor Break"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 4, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 6, 2, 17, -6, -2, ""));

            moveList.Add(new MoveViewModel(Events, "Light Tatsumaki Senpukyaku", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Medium Tatsumaki Senpukyaku
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Super }, 6, 2, 23, 0, -0, "8~41f , 1st hit forces stand, Pursuit Property, 1st hit cancellable, Armor Break"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 40, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 5, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 40, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 5, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 40, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 5, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 5, 2, 23, -4, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Medium Tatsumaki Senpukyaku", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Hard Tatsumaki Senpukyaku
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Super }, 6, 2, 0, 0, 0, "9~50f , 1st hit forces stand, Pursuit Property, 1st hit cancellable, Armor Break"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 40, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 6, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 40, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 5, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 40, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 5, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 40, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 5, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 5, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 5, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 4, 2, 24, -5, -1, ""));

            moveList.Add(new MoveViewModel(Events, "Hard Tatsumaki Senpukyaku", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // EX Tatsumaki Senpukyaku
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Light_Kick = true, Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, -250, new[] { HitViewModel.CancelAbilityEnum.Super }, 6, 2, 0, 0, 0, "8~38f , 1st hit forces stand, Pursuit Property, 1st hit cancellable, Armor Break"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 4, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 4, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 4, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 4, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 3, 1, 23, -3, 1, ""));

            moveList.Add(new MoveViewModel(Events, "EX Tatsumaki Senpukyaku", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));

            // Light Tatsumaki Senpukyaku (Air)
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 8, 2, 0, 0, 0, "Pursuit Property"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 2, 10, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Light Tatsumaki Senpukyaku (Air)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Medium Tatsumaki Senpukyaku (Air)
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 50, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 7, 1, 0, 0, 0, "Pursuit Property"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 10, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Medium Tatsumaki Senpukyaku (Air)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Hard Tatsumaki Senpukyaku (Air)
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 50, 0, 10, new HitViewModel.CancelAbilityEnum[] { }, 7, 1, 0, 0, 0, "Pursuit Property"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 10, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Hard Tatsumaki Senpukyaku (Air)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // EX Tatsumaki Senpukyaku (Air)
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownBack },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back,  Light_Kick = true, Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 40, 0, 50, 0, -250, new HitViewModel.CancelAbilityEnum[] { }, 6, 1, 0, 0, 0, "Pursuit Property"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 0, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 2, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "EX Tatsumaki Senpukyaku (Air)", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));

            #endregion

            #region Super

            // Light Shoryureppa
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward,  Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 0, 0, -1000, new HitViewModel.CancelAbilityEnum[] { }, 2, 2, 0, 0, 0, "1~3f invincible, 4, Pursuit Property"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 8, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 20, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 3, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 7, 43, -29, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Light Shoryureppa", MoveViewModel.MoveTypeEnum.Super, tmpHitList, tmpCommand));

            // Medium Shoryureppa

            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward,  Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 0, 0, -1000, new HitViewModel.CancelAbilityEnum[] { }, 3, 2, 0, 0, 0, "1~4f invincible, 5, Pursuit Property"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 8, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 20, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 3, 0, -29, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 7, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Medium Shoryureppa", MoveViewModel.MoveTypeEnum.Super, tmpHitList, tmpCommand));

            // Hard Shoryureppa

            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward,  Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 0, 0, -1000, new HitViewModel.CancelAbilityEnum[] { }, 3, 2, 0, 0, 0, "1~4f invincible, 5, Pursuit Property"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 8, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 20, 1, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 3, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 7, 0, -29, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Hard Shoryureppa", MoveViewModel.MoveTypeEnum.Super, tmpHitList, tmpCommand));

            #endregion

            #region Ultra

            // Shinryuken

            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward,  Light_Punch = true, Medium_Punch = true, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 10, 2, 82, -94, 0, "1~11f invincible, Pursuit Property, Armor Break"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 5, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 5, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 5, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 5, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 5, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 5, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 5, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 500, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 1, 0, 0, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Shinryuken", MoveViewModel.MoveTypeEnum.Ultra, tmpHitList, tmpCommand));

            // Guren Senpukyaku

            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward,  Light_Kick = true, Medium_Kick = true, Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 75, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 7, 2, 0, 0, 0, "1~7f invincible"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 17, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 5, 93, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 17, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 17, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 17, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 17, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 17, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 17, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 17, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 17, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 23, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 225, 0, 0, 0, 0, new HitViewModel.CancelAbilityEnum[] { }, 0, 0, 50, -40, 0, ""));

            moveList.Add(new MoveViewModel(Events, "Guren Senpukyaku", MoveViewModel.MoveTypeEnum.Ultra, tmpHitList, tmpCommand));

            #endregion


            FighterViewModel kenFighter = new FighterViewModel("Ken", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return kenFighter;
        }


        public static FighterViewModel EHonda()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("E. Honda", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Ibuki()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Ibuki", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Makoto()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Makoto", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Dudley()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Dudley", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Seth()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Seth", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Gouken()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Gouken", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Akuma()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Akuma", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }













        public static FighterViewModel Gen()
        {
            BCMreader.loadBCM("rYu");

            MoveListViewModel moveList = BCMreader.getInputs();
            
            FighterViewModel fighter = new FighterViewModel("Gen", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Dan()
        {
            BCMreader.loadBCM("dan");

            MoveListViewModel moveList = BCMreader.getInputs();

            FighterViewModel fighter = new FighterViewModel("Dan", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Sakura()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Sakura", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Oni()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Oni", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        // Second Row

        public static FighterViewModel Yun()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Yun", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Juri()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Juri", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel ChunLi()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Chun-Li", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Dhalsim()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Dhalsim", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Abel()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Abel", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel CViper()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("C. Viper", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel MBison()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("M. Bison", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Sagat()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Sagat", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Cammy()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Cammy", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel DeeJay()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Dee Jay", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Cody()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Cody", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Guy()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Guy", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Hakan()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Hakan", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Yang()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Yang", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        // Third Row

        public static FighterViewModel EvilRyu()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Evil Ryu", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Guile()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Guile", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Blanka()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Blanka", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Zangief()
        {
            BCMreader.loadBCM("zgf");

            MoveListViewModel moveList = BCMreader.getInputs();

            FighterViewModel fighter = new FighterViewModel("Zangief", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Rufus()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Rufus", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel ElFuerte()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("El Fuerte", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Vega()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Vega", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Balrog()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Balrog", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel FeiLong()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Fei Long", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel THawk()
        {
            BCMreader.loadBCM("hwk");

            MoveListViewModel moveList = BCMreader.getInputs();

            FighterViewModel fighter = new FighterViewModel("T. Hawk", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Adon()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Adon", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        public static FighterViewModel Rose()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            MoveListViewModel moveList = new MoveListViewModel();
            FighterViewModel fighter = new FighterViewModel("Rose", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return fighter;
        }

        //public static FighterViewModel Test2Data()
        //{

        //    BindableCollection<HitViewModel> tmpHitList; ;
        //    CommandViewModel tmpCommand;

        //     MoveListViewModel moveList = new MoveListViewModel();

        //    tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
        //        new InputItemViewModel() { Light_Punch = true } 
        //    });
        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 3, 6, 2, 5, ""));
        //    moveList.Add(new MoveViewModel(Events, "Close", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 3, 21, -3, 3, ""));
        //    moveList.Add(new MoveViewModel(Events, "Close", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 80, 200, 150, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 7, 26, -15, -10, "Forces stand, [] refers to active frames 3~5f"));
        //    moveList.Add(new MoveViewModel(Events, "Close", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 5, 7, -1, 2, ""));
        //    moveList.Add(new MoveViewModel(Events, "Close", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 5, 16, -7, -2, ""));
        //    moveList.Add(new MoveViewModel(Events, "Close", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40 * 70, 0, 125 * 75, 0, 60 * 20, new[] { HitViewModel.CancelAbilityEnum.Super }, 8, 8, 0, 0, 0, ""));
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40 * 70, 0, 125 * 75, 0, 60 * 20, new HitViewModel.CancelAbilityEnum[] { }, 2, 4, 15, -1, 4, ""));
        //    moveList.Add(new MoveViewModel(Events, "Close", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 3, 6, 2, 5, ""));
        //    moveList.Add(new MoveViewModel(Events, "Far", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 4, 14, -4, -1, ""));
        //    moveList.Add(new MoveViewModel(Events, "Far", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 120, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 8, 3, 15, 0, 4, ""));
        //    moveList.Add(new MoveViewModel(Events, "Far", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 6, 6, -1, 2, ""));
        //    moveList.Add(new MoveViewModel(Events, "Far", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 8, 2, 17, -5, -2, ""));
        //    moveList.Add(new MoveViewModel(Events, "Far", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 110, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 9, 4, 20, -6, -2, ""));
        //    moveList.Add(new MoveViewModel(Events, "Far", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 2, 7, 2, 5, ""));
        //    moveList.Add(new MoveViewModel(Events, "crouch", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 4, 8, 2, 5, ""));
        //    moveList.Add(new MoveViewModel(Events, "crouch", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 90, 0, 200, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 8, 28, -18, -13, "Forces stand"));
        //    moveList.Add(new MoveViewModel(Events, "crouch", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 20, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 3, 9, -1, 2, ""));
        //    moveList.Add(new MoveViewModel(Events, "crouch", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 60, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 5, 12, -3, 0, ""));
        //    moveList.Add(new MoveViewModel(Events, "crouch", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 90, 0, 100, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 5, 4, 28, -14, 0, "Untechable knockdown"));
        //    moveList.Add(new MoveViewModel(Events, "crouch", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 10, 7, 0, 0, 0, "Legs projectile invincible until end of startup frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump up", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 5, 5, 0, 0, 0, "Legs projectile invincible until end of active frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump up", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 6, 5, 0, 0, 0, "Legs projectile invincible until end of startup frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump up", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 9, 0, 0, 0, "Legs projectile invincible until end of startup frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump up", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 6, 10, 0, 0, 0, "Legs projectile invincible until end of startup frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump up", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 4, 4, 0, 0, 0, "Legs projectile invincible until end of startup frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump up", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 4, 7, 0, 0, 0, "Legs projectile invincible until end of startup frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump forward", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 50 * 30, 0, 50 * 50, 0, 40 * 20, new HitViewModel.CancelAbilityEnum[] { }, 7, 3 * 4, 0, 0, 0, "Legs projectile invincible until end of startup frames, [1st air hit] floats opponent, [2nd air hit] knock down and can juggle"));
        //    moveList.Add(new MoveViewModel(Events, "Jump forward", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 6, 5, 0, 0, 0, "Legs projectile invincible until end of startup frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump forward", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 4, 8, 0, 0, 0, "Legs projectile invincible until end of startup frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump forward", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 70, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 6, 6, 0, 0, 0, "Legs projectile invincible until end of startup frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump forward", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 7, 7, 0, 0, 0, "Legs projectile invincible until end of startup frames"));
        //    moveList.Add(new MoveViewModel(Events, "Jump forward", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 30, 0, 50, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 17, 1, 0, 0, 0, ""));
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.High, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 1, 2, 14, -2, 3, "Only +1 hit advantage on crouching opponents"));
        //    moveList.Add(new MoveViewModel(Events, "Collarbone Breaker", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 17, 2, 0, 0, 0, ""));
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 0, 2, 18, 0, 4, "Can only cancel in last 3 recovery frames"));
        //    moveList.Add(new MoveViewModel(Events, "Solarplexus Strike", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 10 + 11, 2, 35, -21, -21, ""));
        //    moveList.Add(new MoveViewModel(Events, "Focus Attack LVL 1", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 150, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 18 + 11, 2, 35, -15, 0, ""));
        //    moveList.Add(new MoveViewModel(Events, "Focus Attack LVL 2", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));


        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 140, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 65, 2, 35, 0, 0, ""));
        //    moveList.Add(new MoveViewModel(Events, "Focus Attack LVL 3", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));


        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Techable, 130, 0, 140, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 3, 2, 20, 0, 0, "Untechable knockdown"));
        //    moveList.Add(new MoveViewModel(Events, "Forward Throw", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Techable, 130, 0, 120, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 3, 2, 20, 0, 0, "Untechable knockdown"));
        //    moveList.Add(new MoveViewModel(Events, "Back Throw", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 10 / 20, new[] { HitViewModel.CancelAbilityEnum.Super }, 13, 0, 45, -6, -2, "[air hit] knock down, 16~17f focus cancellable"));
        //    moveList.Add(new MoveViewModel(Events, "Hadoken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

        //    tmpHitList = new BindableCollection<HitViewModel>();
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, -250, new[] { HitViewModel.CancelAbilityEnum.Super }, 12, 0, 40, 1, 0, "knock down, can juggle, [counterhit] floats opponent, 15~16f focus cancellable"));
        //    tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 0, new[] { HitViewModel.CancelAbilityEnum.Super }, 12, 0, 40, 1, 0, ""));
        //    moveList.Add(new MoveViewModel(Events, "Hadoken", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,100,70,200,100,30 ,new[] {HitViewModel.CancelAbilityEnum.Super},3,14,24,-17,0,"1~2f Invincible, 3~4f unthrowable, 3~16f lower body invincibility, 4f~ airborne, knock down, [] refers to active frames 3~14f"));
        //    //        moveList.Add(new MoveViewModel(Events, "Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,80,0,150,0,20,new[] {HitViewModel.CancelAbilityEnum.Super},3,2,0,0,0,"1~5f Invincible, 6~16f lower body invincibility, 5f~ airborne, knock down, "));
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,50,0,50,0,20,new HitViewModel.CancelAbilityEnum[]{},0,12,43,-34,0,"[2nd hit] can juggle"));
        //    //        moveList.Add(new MoveViewModel(Events, "Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,160,60,200,50,20/40[20], new HitViewModel.CancelAbilityEnum[] { } ,3,14,46,-37,0,"1~4f Invincible, 3~4f unthrowable, 5~16f lower body invincibility, 3f~ airborne, knock down, [] refers to active frames 3~14f"));
        //    //        moveList.Add(new MoveViewModel(Events, "Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,80*60,0,100*100,0,-250/0,new[] {HitViewModel.CancelAbilityEnum.Super},3,2*12,30 + After landing 18,-39,0,"1~16f Invincible, 6f~ airborne, knock down, [2nd hit] can juggle"));
        //    //        moveList.Add(new MoveViewModel(Events, "Shoryuken", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,100,0,200,0,30/30, new HitViewModel.CancelAbilityEnum[] { } ,11,2(6)2,12 + After landing 5,-6,0,"7~20f lower body immune to projectiles, 7f~ airborne, knock down, armor break, cannot hit crouching opponents, [2nd hit] aimed backwards"));
        //    //        moveList.Add(new MoveViewModel(Events, "Hurricane Kick", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,110,0,200,0,30/30, new HitViewModel.CancelAbilityEnum[] { } ,12,2(6)2(6)2(6)2(6)2,18 + After landing 3,-2,0,"7~45f lower body immune to projectiles, 7f~ airborne, knock down, armor break, cannot hit crouching opponents, [2nd hit, 4th hit] aimed backwards"));
        //    //        moveList.Add(new MoveViewModel(Events, "Hurricane Kick", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,120,0,200,0,30/30, new HitViewModel.CancelAbilityEnum[] { } ,12,2(6)2(6)2(6)2(6)2,18 + After landing 3,-2,0,"7~45f lower body immune to projectiles, 7f~ airborne, knock down, armor break, cannot hit crouching opponents, [2nd hit, 4th hit] aimed backwards"));
        //    //        moveList.Add(new MoveViewModel(Events, "Hurricane Kick", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,30x4*40,0,40x5,0,-250/0, new HitViewModel.CancelAbilityEnum[] { } ,11,1(3)1(3)1(3)1(3)1,18 + After landing 3,-1,0,"6~27f lower body immune to projectiles, 6f~ airborne, [1st-4th hit] forces stand, [air hit, 5th hit] knock down, armor break, can juggle, [2nd, 4th hit] aimed backwards"));
        //    //        moveList.Add(new MoveViewModel(Events, "Hurricane Kick", MoveViewModel.MoveTypeEnum.ExtraSpecialSpecial, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,70,0,100,0,10/40, new HitViewModel.CancelAbilityEnum[] { } ,9,2(6)2(6)2,After landing 10,0,0,"knock down, [2nd, 4th hit] aimed backwards"));
        //    //        moveList.Add(new MoveViewModel(Events, "Hurricane Kick  (air)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,80,0,100,0,10/40, new HitViewModel.CancelAbilityEnum[] { } ,9,2(6)2(6)2,After landing 10,0,0,"knock down, [2nd, 4th hit] aimed backwards"));
        //    //        moveList.Add(new MoveViewModel(Events, "Hurricane Kick  (air)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,90,0,100,0,10/40, new HitViewModel.CancelAbilityEnum[] { } ,9,2(6)2(6)2,After landing 10,0,0,"knock down, [2nd, 4th hit] aimed backwards"));
        //    //        moveList.Add(new MoveViewModel(Events, "Hurricane Kick  (air)", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,40x5,0,50x5,0,-250/0, new HitViewModel.CancelAbilityEnum[] { } ,7,1(3)1(3)1(3)1(3)1,After landing 4,0,0,"knock down, can juggle, [2nd, 4th hit] aimed backwards"));
        //    //        moveList.Add(new MoveViewModel(Events, "Hurricane Kick  (air)", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,50x4*100,0,0,0,-1000/0, new HitViewModel.CancelAbilityEnum[] { } ,1+2,0,Total 52,11,0,"1f Invincible, [1st-4th air hit] untechable knockdown, [5th hit] untechable knockdown, can juggle"));
        //    //        moveList.Add(new MoveViewModel(Events, "Super Combo", MoveViewModel.MoveTypeEnum.Super, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,42x7*75,0,0,0,0/0, new HitViewModel.CancelAbilityEnum[] { } ,0+11,0,Total 120,-25,0,"1~9f Invincible, [1st-7th air hit] or [8th hit] untechable knockdown, can juggle"));
        //    //        moveList.Add(new MoveViewModel(Events, "Ultra Combo 1", MoveViewModel.MoveTypeEnum.Ultra, tmpHitList, tmpCommand));

        //    //tmpHitList= new BindableCollection<HitViewModel>(); 
        //    //   tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid,270*38x4*50x3,270*233,0,0,0/0, new HitViewModel.CancelAbilityEnum[] { } ,0+8,3*3x7,43+ After landing 41,-84,0,"1~10f Invincible, 11~31f lower body invincibility, 11f~ airborne, untechable knockdown, [2nd hit] (translate) can juggle, armor break, 1st hit goes into animation, [] refers to animation, guard advantage assumes 2nd hit"));
        //    //        moveList.Add(new MoveViewModel(Events, "Ultra Combo 2", MoveViewModel.MoveTypeEnum.Ultra, tmpHitList, tmpCommand));

        //    FighterViewModel fighter = new FighterViewModel(events, "Ryu", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
        //    return fighter;
        //}
    }


}
