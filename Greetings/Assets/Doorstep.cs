using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Doorstep : MonoBehaviour {

	public Player Player;
    public PeopleFactory PeopleFactory;
    public List<People> PeopleList;
    public People CurrentPerson;
    public Timer Timer;
    
    

	void Start () {

        PeopleList = new List<People>();
        PeopleFactory = new PeopleFactory();
        

        openDoor();

	}

    public IEnumerator CheckForTimeout()
    {
        
        
        while(Timer.TimerRunning==true)
        {
            yield return true;
        }

        if(Timer.Time==CurrentPerson.MaxGreetingTime)
        {

            HandleGreetings(Greetings.None);
        }


    }

    public IEnumerator LogList()
    {
        string result= "";
        for(int i=0; i< PeopleList.Count;i++)
        {

            result += "("+PeopleList[i].GreetingTime+" seconds , " + PeopleList[i].GreetedRight+")";
        }
        Debug.Log(result);
        yield return null;
    }

    public void openDoor()
    {

        
        CurrentPerson = PeopleFactory.createRandom();
        PeopleList.Add(CurrentPerson);
        Timer = new Timer();


        StartCoroutine(CheckForTimeout());
        StartCoroutine(Timer.StartTimer(CurrentPerson.MaxGreetingTime));

        Debug.Log("Hello im a " + CurrentPerson.Role.ToString());
        
    }

    public People GetCurrentPerson()
    {
        return PeopleList[PeopleList.Count-1];
    }

	public void HandleGreetings(Greetings PlayerGreeting)
    {
        if (PlayerGreeting == GetCurrentPerson().WantedGreeting)
        {
            CurrentPerson.SetGreetedRight(true);
        }
        else
        {
            CurrentPerson.SetGreetedRight(false);
        }

        Timer.EndTimer();
        CurrentPerson.SetGreetingTime(Timer.Time);
        StartCoroutine(LogList());
        openDoor();
    }

	void Update () {
		
	}
}
