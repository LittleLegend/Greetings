using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using System;

public class Shake : Gesture {

    public Shake(Doorstep Doorstep, Player Player)
    {
        this.Doorstep = Doorstep;
        this.Player = Player;
    }

    public override void greet()
    {
        Doorstep.HandleGreetings(Greetings.Shake);
    }

    public override void checkInput()
    {
       
    }
}
