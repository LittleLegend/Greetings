using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Kiss : Gesture{

    public Kiss(Doorstep Doorstep, Player Player)
    {
        this.Doorstep = Doorstep;
        this.Player = Player;
    }
    
    public override void greet()
    {
        Doorstep.HandleGreetings(Greetings.Kiss);
    }

    public override void checkInput()
    {
        if( Input.GetMouseButton(0))
        {
            Player.setGreetCommand(this);
        }
    }

    public override void undoGreet()
    {
        Doorstep.PeopleList.RemoveAt(Doorstep.PeopleList.Count - 1);
    }
}


