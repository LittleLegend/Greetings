using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Player: MonoBehaviour {

    public Doorstep Doorstep;

    public void Shake()
    {
        
        Doorstep.HandleGreetings(Greetings.Shake);
    }
    public void Hug()
    {
        Doorstep.HandleGreetings(Greetings.Hug);
    }

    public void Kiss()
    {
        Doorstep.HandleGreetings(Greetings.Kiss);
    }

    public void Bump()
    {
        Doorstep.HandleGreetings(Greetings.Bump);
    }

}
