﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;


public class PeopleFactory {

    public DataManager DataManager;
    
    public PeopleFactory(DataManager DataManager)
    {
        this.DataManager = DataManager;
    }

    public People createRandom(int points)
    {
        int rand = Random.Range(1,5);
        People result=null;

        switch (rand)
        {
            case 1:
                result= createFriend(points);
                break;

            case 2:
                result = createMother(points);
                break;

            case 3:
                result = createWife(points);
                break;

            case 4:
                result = createBoss(points);
                break;
        }

        return result;
        }
    
    public People createMother(int points)
    {
        People result = new People();
        result.Type = Roles.Mother;
        result.MaxGreetingTime = DataManager.GetMaxGreetTime(points);
        result.WantedGreeting = DataManager.GetWantedGreeting("mother");

        return result;
    }

    public People createFriend(int points)
    {
        People result = new People();
        result.Type = Roles.Friend;
        result.MaxGreetingTime = DataManager.GetMaxGreetTime(points);
        result.WantedGreeting = DataManager.GetWantedGreeting("friend");

        return result;
    }

    public People createBoss(int points)
    {
        People result = new People();
        result.Type = Roles.Boss;
        result.MaxGreetingTime = DataManager.GetMaxGreetTime(points);
        result.WantedGreeting = DataManager.GetWantedGreeting("boss");

        return result;
    }

    public People createWife(int points)
    {
        
        People result = new People();
        
        result.Type = Roles.Wife;
        result.MaxGreetingTime = DataManager.GetMaxGreetTime(points);
        result.WantedGreeting = DataManager.GetWantedGreeting("wife");

        return result;
    }
}
