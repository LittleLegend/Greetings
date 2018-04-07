using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PeopleFactory {

    public Boss Boss;
    public Wife Wife;
    public Friend Friend;
    public Mother Mother;
    


    public PeopleFactory()
    {
        
    }

    public People createRandom()
    {
        int rand = Random.Range(1,4);
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

    public Boss creatBoss()
    {
        Boss = new Boss();
        return Boss;
    }
    public Wife  creatWife()
    {
        Wife = new Wife();
        return Wife;
    }
    public Friend  creatFriend()
    {
        Friend = new Friend();
        return Friend;
    }
    public Mother  creatMother()
    {
        Mother = new Mother();
        return Mother;
    }
}
