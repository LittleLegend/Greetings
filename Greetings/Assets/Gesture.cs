using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public abstract class Gesture{

    public Doorstep Doorstep;

    public Player Player;
    
    public abstract void greet();

    public abstract void checkInput();

    public abstract void undoGreet();
    
}
