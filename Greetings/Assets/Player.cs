using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Player: MonoBehaviour {

    public Doorstep Doorstep;

    public void Shake()
    {
        Doorstep.CompareGreetings(Greetings.Shake);
    }
    public void Hug()
    {
        Doorstep.CompareGreetings(Greetings.Hug);
    }

    public void Kiss()
    {
        Doorstep.CompareGreetings(Greetings.Kiss);
    }

    public void Bump()
    {
        Doorstep.CompareGreetings(Greetings.Bump);
    }

}
