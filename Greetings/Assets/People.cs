﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

    public abstract class People
    {

        
        
        public Greeting WantedGreeting;
        public Roles Type;
        public bool Greeted=false;
        public bool GreetedRight;
        public float GreetingTime;
        public float MaxGreetingTime;
        



    public void SetGreetedRight(bool GreetedRight)
    {
        Greeted = true;
        this.GreetedRight = GreetedRight;
    }

    public void SetGreetingTime(float GreetingTime)
    {
        this.GreetingTime = GreetingTime;
    }



}
