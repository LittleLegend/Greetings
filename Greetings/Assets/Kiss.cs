using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Kiss : Gesture{

    public Kiss(Doorstep Doorstep)
    {
        this.Doorstep = Doorstep;
    }
    
    public override void greet()
    {
        Doorstep.HandleGreetings(Greetings.Kiss);
    }

    public override void checkInput()
    {
        throw new NotImplementedException();
    }
}


