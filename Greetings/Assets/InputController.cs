using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class InputController:MonoBehaviour{

   public Player Player;
   


    public bool InputLocked;
  
    void Update()
    {
        if (Player.Doorstep.CurrentGameState == GameState.InputGreeting && Player.Doorstep.AnimationController.playing ==false)
        {
            Debug.Log("test");
            
            ListenForTouch();
            ListenForClick();


        }

       
    }

    public void ButtonOpenDoor()
    {

        if (Player.Doorstep.CurrentGameState == GameState.OpenDoor)
        {
            Player.OpenDoor();
        }

    }

    public void ListenForTouch()
    {
        if(Input.touchCount==1 && Input.GetTouch(0).phase==TouchPhase.Ended)
        {
            InputLocked = true;
            Player.Kiss();
        }
    }
    public void ListenForClick()
    {

        if (Input.GetMouseButtonUp(0))
        {
            InputLocked = true;
            Player.Kiss();
        }

    }

   

}
