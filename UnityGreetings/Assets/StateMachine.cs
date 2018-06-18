using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class StateMachine: MonoBehaviour{

    public GameState CurrentGameState;
    public People CurrentGuest;
    Timer Timer;

    public References References;
    
    PeopleFactory PeopleFactory;
    DataManager DataManager;
    ScoreController ScoreController;
    InputController InputController;

    public AnimationController AnimationController;
    public UIController UIController;
    

    public void Start()
    {
        

        CurrentGameState = GameState.Setup;
    }

    public void Update()
    {

        Setup();
        ButtonClick();
        OpenDoor();
        SettingTimer();
        InputGreetings();
        CompareGreetings();
        WatchScene();
        CloseDoor();
        SetGuest();
    }
  

    public void Setup()
    {
        if (CurrentGameState == GameState.Setup)
        {
            
            PeopleFactory = References.PeopleFactory;
            DataManager = References.DataManager;
            ScoreController = References.ScoreController;
            InputController = References.InputController;
            
            DataManager.Load();
            CurrentGuest = PeopleFactory.createRandom(ScoreController.GetCombo());
            ScoreController.PeopleList.Add(CurrentGuest);
            
            AnimationController.SetGuest(CurrentGuest.Type);
            
            CurrentGameState = GameState.ButtonClick;

        }
    }

    public void ButtonClick()
    {
        if (CurrentGameState == GameState.OpenDoor)
        {
            UIController.OpenDoorButton(0);
        }
    }

    public void OpenDoor()
    {
        if (CurrentGameState == GameState.OpenDoor)
        {
            AnimationController.OpenDoorAnimation(CurrentGuest);
            if (AnimationController.IsDoorOpen())
            {

                CurrentGameState = GameState.SettingTimer;
            }
        }
    }
    public void SettingTimer()
    {
        if (CurrentGameState == GameState.SettingTimer)
        {
            
            Timer = new Timer();
            Timer.StartTimer(CurrentGuest.MaxGreetingTime);
            InputController.CreateGestures();
            CurrentGameState = GameState.InputGreetings;
        }
    }

    public void InputGreetings()
    {
        if (CurrentGameState == GameState.InputGreetings)
        {
            if (Timer.Time == CurrentGuest.MaxGreetingTime)
            {
                //miss
            }

        }
    }
        public void CompareGreetings()
    {
        if (CurrentGameState == GameState.CompareGreetings)
        {
            InputController.WatchSceneGesture();

            if (InputController.InputGreeting == CurrentGuest.WantedGreeting)
            {
                CurrentGuest.SetGreetedRight(true);
                ScoreController.AddCombo(CurrentGuest.combo);
                ScoreController.AddPoints(CurrentGuest.points * ScoreController.GetCombo());

            }
            else
            {
                CurrentGuest.SetGreetedRight(false);
                ScoreController.ResetCombo();
                
            }
            
            Timer.EndTimer();

            CurrentGuest.SetGreetingTime(Timer.Time);
            
            CurrentGameState = GameState.WatchScene;
        }
    }

     public void WatchScene()
    {
        if (CurrentGameState == GameState.WatchScene)
        {
<<<<<<< HEAD
            
            AnimationController.WatchSceneAnimation(CurrentGuest, Player.PlayerGreeting);
=======
            AnimationController.WatchSceneAnimation(CurrentGuest, InputController.InputGreeting);
>>>>>>> d26d74ecb895e454f6606da7d822d6714e83ba25
        }
    }

    public void CloseDoor()
    {
        if (CurrentGameState == GameState.CloseDoor)
        {
            InputController.RemoveGestures();
            AnimationController.CloseDoorAnimation();

            if (AnimationController.IsDoorClosed())
            {
                CurrentGameState = GameState.SetGuest;
            }

        }
    }

    public void SetGuest()
    {
        if (CurrentGameState == GameState.SetGuest)
        {
            CurrentGuest = PeopleFactory.createRandom(ScoreController.GetCombo());
            ScoreController.PeopleList.Add(CurrentGuest);
            AnimationController.SetGuest(CurrentGuest.Type);
            CurrentGameState = GameState.ButtonClick;

        }
    }
}


