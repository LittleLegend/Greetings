using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class InputController{

    Player Player;
    Camera Camera;
    public bool InputLocked;

    public List<Gesture> GestureList;
    public ICommand CheckInputCommand;

    public InputController(Camera Camera, Player Player)
    {
        this.Camera = Camera;
        this.Player = Player;
    }

    public void InputGreetingInput()
    {
        checkGreeting();
        releaseGreeting();
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
