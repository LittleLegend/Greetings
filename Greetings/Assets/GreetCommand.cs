using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using System;

public  class GreetCommand:ICommand
{

    public IGesture Gesture;

    
    public GreetCommand(IGesture Gesture)
    {
        this.Gesture = Gesture;
    }

    public void execute()
    {
        Gesture.greet();
    }
 
    public void undo()
    {
        throw new NotImplementedException();
    }
}
