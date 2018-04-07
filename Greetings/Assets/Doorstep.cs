using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Doorstep : MonoBehaviour {

	public Player Player;
    public PeopleFactory PeopleFactory;
    public List<People> PeopleList;
    public People CurrentPerson;
    
	void Start () {

        PeopleList = new List<People>();
        PeopleFactory = new PeopleFactory();

        openDoor();

	}
	
    public void openDoor()
    {
        CurrentPerson = PeopleFactory.createRandom();
        PeopleList.Add(CurrentPerson);
        Debug.Log("Hallo ich bin ein " + CurrentPerson.Role.ToString());
    }

    public People GetCurrentPerson()
    {
        return PeopleList[PeopleList.Count];
    }

	public bool CompareGreetings(Greetings PlayerGreeting)
    {
        if(PlayerGreeting == GetCurrentPerson().WantedGreeting)
        {
            return true;
        }else { return false; }
    }

	void Update () {
		
	}
}
