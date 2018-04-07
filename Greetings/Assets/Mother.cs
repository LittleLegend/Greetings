using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Mother : People
    {

        public Mother()
        {
        MaxGreetingTime = 5;
        WantedGreeting = Greetings.Hug;
        Role = Roles.Mother;
    }
    }
