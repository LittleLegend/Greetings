using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;


public class PeopleFactory {

   
    public People createRandom()
    {
        int rand = Random.Range(1,5);
        People result=null;

        switch (rand)
        {
            case 1:
                result = new Boss();
                break;

            case 2:
                result = new Wife();
                break;

            case 3:
                result = new Friend();
                break;

            case 4:
                result = new Mother();
                break;
        }

        return result;
        }

    public People createPeople(Roles Role )
    {
        People result = null;

        switch (Role)
        {
            case Roles.Boss:
                result = new Boss();
                break;

            case Roles.Wife:
                result = new Wife();
                break;

            case Roles.Friend:
                result = new Friend();
                break;

            case Roles.Mother:
                result = new Mother();
                break;
        }

        return result;
    }

    
}
