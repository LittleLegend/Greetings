﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Kiss : IGesture{

    
    public bool checkInput()
    {
        throw new NotImplementedException();
    }

    public Greetings greet()
    {
        return Greetings.Kiss;
    }
}