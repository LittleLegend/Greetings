using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Mother : People
    {

        public Mother()
        {
            WantedGreeting = Greetings.Hug;
        Role = Roles.Mother;
    }
    }
