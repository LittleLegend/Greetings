using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using System;

public class Shake : IGesture {


   
    public bool checkInput()
    {
        throw new NotImplementedException();
    }

    public Greetings greet()
    {
        return Greetings.Shake;
    }
}
