using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using DigitalRubyShared;

public class InputController{

    Player Player;
    Camera Camera;
    GestureAdapter GestureAdapter;
    StateMachine StateMachine;
    
    public bool InputLocked;

    public List<Gesture> GestureList;
    public ICommand CheckInputCommand;

    public InputController(Camera camera, Player player, GestureAdapter gestureAdapter, StateMachine stateMachine )
    {
        Camera = camera;
        Player = player;
        GestureAdapter = gestureAdapter;
        StateMachine = stateMachine;
    }

    public void CreateGestures()
    {
        GestureAdapter.CreateTab(Tapgesture_StateUpdated);
        s
    }

    public void RemoveGestures()
    {
        GestureAdapter.RemoveTab();

    }

    public void Tapgesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            Player.PlayerGreeting = Greetings.Kiss;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }
    }

    public void checkGreeting()
    {
                for (int i = 0; i < GestureList.Count; i++)
                {
                    checkInput(GestureList[i]);
                } 
    }

    public void releaseGreeting()
    { 
            if (Input.GetMouseButtonUp(0))
            {
                Player.greet();
            
            }
    }
    
    public void checkInput(Gesture Gesture)
    {
        Gesture.Screenpoint = GetScreenTouchPoint();
        CheckInputCommand = new CheckInputCommand(Gesture);
        CheckInputCommand.execute();
    }
    
    public Vector3 GetScreenTouchPoint()
    {
        Vector3 ScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        ScreenPoint = Camera.ScreenToViewportPoint(ScreenPoint);

        return ScreenPoint;
    }
    
    public void WatchSceneInput()
    {
                if (Input.GetMouseButtonDown(0))
                {
                    Player.closeDoor();
                }
    }
}
