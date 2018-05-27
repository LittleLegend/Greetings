using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class StateMachine: MonoBehaviour{

    public GameState CurrentGameState;
    public People CurrentGuest;
    Timer Timer;

    public References References;

    Player Player;
    GestureFactory GestureFactory;
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
        OpenDoor();
        SettingTimer();
        InputGreetingState();
        CompareGreetings();
        WatchScene();
        CloseDoor();
        ClosingDoor();
    }
  

    public void Setup()
    {
        if (CurrentGameState == GameState.Setup)
        {
            Player = References.Player;
            GestureFactory = References.GestureFactory;
            PeopleFactory = References.PeopleFactory;
            DataManager = References.DataManager;
            ScoreController = References.ScoreController;
            InputController = References.InputController;

            InputController.GestureList = GestureFactory.createGestureList();
            DataManager.Load();
            CurrentGuest = PeopleFactory.createRandom(ScoreController.GetCombo());
            ScoreController.PeopleList.Add(CurrentGuest);
            
            AnimationController.SetGuest(CurrentGuest.Type);
            
            CurrentGameState = GameState.OpenDoor;

        }
    }

    public void OpenDoor()
    {
        if (CurrentGameState == GameState.OpenDoor)
        {
            UIController.OpenDoorButton(0);
        }
    }

    public void SettingTimer()
    {
        if (CurrentGameState == GameState.SettingTimer)
        {
            Timer = new Timer();
            Timer.StartTimer(CurrentGuest.MaxGreetingTime);
            CurrentGameState = GameState.InputGreeting;
        }
    }

    public void InputGreetingState()
    {
        if (CurrentGameState == GameState.InputGreeting)
        {
            AnimationController.InputGreetingAnimation(CurrentGuest);
            InputController.InputGreetingInput();
            
            if (Timer.Time == CurrentGuest.MaxGreetingTime)
            {
                Player.miss();
            }

        }
    }
        public void CompareGreetings()
    {
        if (CurrentGameState == GameState.CompareGreetings)
        {
            
            if (Player.PlayerGreeting == CurrentGuest.WantedGreeting)
            {
                CurrentGuest.SetGreetedRight(true);
                ScoreController.AddPoints(CurrentGuest.points);
                ScoreController.AddCombo(CurrentGuest.combo);

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
            InputController.WatchSceneInput();

            AnimationController.WatchSceneAnimation(CurrentGuest, Player.PlayerGreeting);
        }
    }

    public void CloseDoor()
    {
        if (CurrentGameState == GameState.CloseDoor)
        {
            
            AnimationController.CloseDoorAnimation();
            
            CurrentGameState = GameState.ClosingDoor;

        }
    }

    public void ClosingDoor()
    {
        if (CurrentGameState == GameState.CloseDoor)
        {


            CurrentGuest = PeopleFactory.createRandom(ScoreController.GetCombo());
            ScoreController.PeopleList.Add(CurrentGuest);
            AnimationController.SetGuest(CurrentGuest.Type);

        }
    }
}


