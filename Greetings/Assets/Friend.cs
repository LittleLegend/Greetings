using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Friend : People
    {
        public Friend()
        {
        MaxGreetingTime = 5;
        Type = Roles.Friend;
        WantedGreeting = Greetings.Bump;
    }

    

    }
