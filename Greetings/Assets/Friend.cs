using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Friend : People
    {
        public Friend()
        {
        MaxGreetingTime = 5;
        WantedGreeting = Greetings.Bump;
        Role = Roles.Friend;
    }

    }
