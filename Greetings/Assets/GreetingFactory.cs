using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class GreetingFactory{

   
    
    public Greeting createGreeting(Roles CurrentGuest)
    {
        Greeting result = null;

        switch (CurrentGuest)
        {
            case Roles.Wife:
                result = new Kiss();
                break;

        }

        return result;
    }

    public Kiss createKiss()
    {
        return new Kiss();
    }
    public Bump createBump()
    {

        return new Bump();
    }
    public Shake createShake()
    {

        return new Shake();
    }
    public Hug createHug()
    {
        return new Hug();
    }

}
