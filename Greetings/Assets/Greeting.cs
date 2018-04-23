using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public abstract class Greeting 
{

    public Greetings Type;
    public  bool isGreeting()
    {
        if (isGreetingDevice() || isGreetingEditor())
        {
            return true;
        }
        else { return false; }

    }
    public abstract bool isGreetingDevice();
    public abstract bool isGreetingEditor();

}
