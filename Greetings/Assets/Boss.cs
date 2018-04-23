using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

    public class Boss : People
    {

        public Boss()
        {
        MaxGreetingTime = 5;
        Type = Roles.Boss;
        WantedGreeting = Greetings.Shake;
    }

    }
