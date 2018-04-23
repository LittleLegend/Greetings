using System.Collections;
using System.Collections.Generic;
using UnityEngine;



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

    public Boss createBoss()
    {
        return new Boss();
    }
    public Wife  createWife()
    {
        
        return new Wife();
    }
    public Friend  createFriend()
    {
       
        return new Friend();
    }
    public Mother  createMother()
    {
        return new Mother();
    }

}
