using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Player: MonoBehaviour {

    [SerializeField]
    public Doorstep Doorstep;

    [SerializeField]
    public InputController InputController;

    public ICommand GreetCommand;
   
    
    public void setGreetCommand(Gesture Gesture)
    {
        GreetCommand = new GreetCommand(Gesture);
    }

    public void greet()
    {
        GreetCommand.execute();
    }
    
    public void OpenDoor()
    {
        Doorstep.StartGreetTime();
    }

    public void CloseDoor()
    {
        Doorstep.EndGreetTime();
    }

}
