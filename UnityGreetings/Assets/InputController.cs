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
<<<<<<< HEAD
        GestureAdapter.CreateTab(Tapgesture_StateUpdated);
        GestureAdapter.CreateLongPress(Longpressgesture_StateUpdated);
        GestureAdapter.CreateSwipe(Swipegesture_StateUpdated);
        GestureAdapter.CreateScale(Scalesgesture_StateUpdated);

=======
        
        
>>>>>>> d26d74ecb895e454f6606da7d822d6714e83ba25
    }

    public void RemoveGestures()
    {
        

    }

    public void WatchSceneGesture()
    {
        GestureAdapter.RemoveTab();
        GestureAdapter.CreateTab(WatchsceneTabgesture_StateUpdated);

    }

    public void WatchsceneTabgesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended && StateMachine.CurrentGameState == GameState.InputGreetings)
        {
<<<<<<< HEAD
            
            StateMachine.CurrentGameState = GameState.CloseDoor;
        }
    }

    public void Scalesgesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            Player.PlayerGreeting = Greetings.Hug;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }
    }

    public void Longpressgesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            Player.PlayerGreeting = Greetings.Kiss;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }
    }

    public void Tapgesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            Player.PlayerGreeting = Greetings.Bump;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }
    }

    public void Swipegesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            Player.PlayerGreeting = Greetings.Shake;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }
    }

   
=======
            InputGreeting = Greetings.Kiss;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }

        if (gesture.State == GestureRecognizerState.Ended && StateMachine.CurrentGameState == GameState.WatchScene)
        {
            StateMachine.CurrentGameState = GameState.CloseDoor;
        }
    }
    
>>>>>>> d26d74ecb895e454f6606da7d822d6714e83ba25
}
