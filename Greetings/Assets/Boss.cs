using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

    public class Boss : People
    {

        public Boss()
        {
        MaxGreetingTime = 5;
            WantedGreeting = Greetings.Shake;
            Role = Roles.Boss;
        }

    }
