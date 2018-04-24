using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class InputController:MonoBehaviour{

    public Player Player;
    public bool InputLocked;
    public List<Gesture> GestureList;

    public ICommand CheckInputCommand;
    
    void Update()
    {
        InputGreeting();
        WatchScene();
    }

    
    public void checkInput(Gesture Gesture)
    {
        CheckInputCommand = new CheckInputCommand(Gesture);
        CheckInputCommand.execute();

    }

    public void InputGreeting()
    {
        if (Player.Doorstep.CurrentGameState == GameState.InputGreeting && Player.Doorstep.AnimationController.playing == false)
        {

            if(Player.Doorstep.GreetingFactory.createKiss().isGreeting())
            {
                Player.Kiss();
            }



        }
    }

    public void WatchScene()
    {
        if (Player.Doorstep.CurrentGameState == GameState.WatchScene && Player.Doorstep.AnimationController.sceneEnded == true)
        {
            if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                Player.CloseDoor();
            }

            if (Input.GetMouseButtonUp(0))
            {
                Player.CloseDoor();
            }
        }
        
    }
    
    public void ButtonOpenDoor()
    {

        if (Player.Doorstep.CurrentGameState == GameState.OpenDoor && Player.Doorstep.AnimationController.playing == false)
        {
            Player.OpenDoor();
        }

    }
    
}
