using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Shake : Greeting {


    public Shake()
    {
        Type = Greetings.Shake;

    }

    public override bool isGreetingDevice()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            return true;
        }
        else { return false; }
    }

    public override bool isGreetingEditor()
    {
        if (Input.GetMouseButtonUp(0))
        {
            return true;
        }
        else { return false; }
    }
}
