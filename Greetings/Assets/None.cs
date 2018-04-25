using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class None : Gesture {

    public None(Doorstep Doorstep, Player Player)
    {
        this.Doorstep = Doorstep;
        this.Player = Player;
    }

    public override void greet()
    {
        Doorstep.HandleGreetings(Greetings.None);
    }

    public override void checkInput()
    {
        
    }

    public override void undoGreet()
    {
        Doorstep.PeopleList.RemoveAt(Doorstep.PeopleList.Count - 1);
    }
}
