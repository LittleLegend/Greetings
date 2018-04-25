using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using System;

public class Bump : Gesture
{
    public Bump(Doorstep Doorstep,Player Player)
    {
        this.Doorstep = Doorstep;
        this.Player = Player;
    }

    public override void greet()
    {
        Doorstep.HandleGreetings(Greetings.Bump);
    }

    public override void checkInput()
    {
        
    }

    public override void undoGreet()
    {
        Doorstep.PeopleList.RemoveAt(Doorstep.PeopleList.Count - 1);
    }
}
