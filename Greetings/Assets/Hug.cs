using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Hug : Gesture {

    public Hug(Doorstep Doorstep, Player Player)
    {
        this.Doorstep = Doorstep;
        this.Player = Player;
    }

    public override void greet()
    {
        Doorstep.HandleGreetings(Greetings.Hug);
    }

    public override void checkInput()
    {
        
    }
}
