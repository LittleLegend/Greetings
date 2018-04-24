using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class InputController: MonoBehaviour{

    public Player Player;
    public bool InputLocked;

    public List<Gesture> GestureList;
    public ICommand CheckInputCommand;

    public void startInputGreeting()
    {
        StartCoroutine(checkGreeting());
        StartCoroutine(releaseGreeting());
        
    }

    public void startWatchScene()
    {
        StartCoroutine(watchScene());
    }

    public void checkInput(Gesture Gesture)
    {
        CheckInputCommand = new CheckInputCommand(Gesture);
        CheckInputCommand.execute();
        
    }

    public IEnumerator checkGreeting()
    {
        while (Player.Doorstep.CurrentGameState == GameState.InputGreeting)
        {
            if ( Player.Doorstep.AnimationController.playing == false)
            {
                
                for(int i =0; i <GestureList.Count;i++)
                {
                    checkInput(GestureList[i]);
                }
            }
            yield return null;
        }
        
    }

    public IEnumerator releaseGreeting()
    {
        while (Player.Doorstep.CurrentGameState == GameState.InputGreeting)
        {
            if (Player.Doorstep.AnimationController.playing == false &&
                Input.GetMouseButtonUp(0))
            {
                Player.greet();
            }
            yield return null;
        }
        
    }

    public IEnumerator watchScene()
    {
        while (Player.Doorstep.CurrentGameState == GameState.WatchScene)
        {
            if (Player.Doorstep.AnimationController.sceneEnded == true)
            {
                if (Input.GetMouseButtonUp(0))
                {
                    Player.CloseDoor();
                }
            }
            yield return null;
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
