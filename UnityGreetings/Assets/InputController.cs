using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using DigitalRubyShared;

public class InputController{

    
    GestureAdapter GestureAdapter;
    StateMachine StateMachine;
    
    public Greetings InputGreeting;

   
    public InputController( GestureAdapter gestureAdapter, StateMachine stateMachine )
    {
        GestureAdapter.CreateTab(Tapgesture_StateUpdated);
        GestureAdapter = gestureAdapter;
        StateMachine = stateMachine;
    }
    

    public void CreateGestures()
    {
        
        
    }

    public void RemoveGestures()
    {
        

    }

    public void Tapgesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended && StateMachine.CurrentGameState == GameState.InputGreetings)
        {
            InputGreeting = Greetings.Kiss;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }

        if (gesture.State == GestureRecognizerState.Ended && StateMachine.CurrentGameState == GameState.WatchScene)
        {
            StateMachine.CurrentGameState = GameState.CloseDoor;
        }
    }
    
}
