using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Hug : Gesture {

    public Hug(Doorstep Doorstep)
    {
        this.Doorstep = Doorstep;
    }

    public override void greet()
    {
        Doorstep.HandleGreetings(Greetings.Hug);
    }

    public override void checkInput()
    {
        throw new NotImplementedException();
    }
}
