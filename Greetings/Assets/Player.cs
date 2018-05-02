using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Player: MonoBehaviour {

    [SerializeField]
    public Doorstep Doorstep;
    
    public ICommand GreetCommand;

    public void setGreetCommand(Gesture Gesture)
    {
        GreetCommand = new GreetCommand(Gesture);
        
    }

    public void resetGreetCommand()
    {
        GreetCommand = new GreetCommand(new None(Doorstep,this));
    }

    public void undoGreet()
    {
        GreetCommand.undo();
        resetGreetCommand();
    }

    public void greet()
    {
        GreetCommand.execute();
        resetGreetCommand();
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
