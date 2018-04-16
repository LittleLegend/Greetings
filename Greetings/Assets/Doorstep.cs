using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Doorstep : MonoBehaviour {

    [SerializeField]
    public Player Player;

    [SerializeField]
    public PeopleFactory PeopleFactory;

    [SerializeField]
    public List<People> PeopleList;

    [SerializeField]
    public People CurrentGuest;

    [SerializeField]
    public Animator Doorstep_Animator;
    
    [SerializeField]
    public AnimationController AnimationController;
    
    [SerializeField]
    public Timer Timer;

    [SerializeField]
    public GameState CurrentGameState;

    void Start () {

        PeopleList = new List<People>();
        PeopleFactory = new PeopleFactory();
        CurrentGameState = GameState.OpenDoor;
        
	}

    public IEnumerator CheckForTimeout()
    {
        
        
        while(Timer.TimerRunning==true)
        {
            yield return true;
        }

        if(Timer.Time==CurrentGuest.MaxGreetingTime)
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

    public void StartGreetTime()
    {

        
        CurrentGuest = PeopleFactory.createRandom();
        PeopleList.Add(CurrentGuest);
        Timer = new Timer();
        AnimationController.OpenDoor();
        CurrentGameState = GameState.InputGreeting;



        StartCoroutine(CheckForTimeout());
        StartCoroutine(Timer.StartTimer(CurrentGuest.MaxGreetingTime));

        Debug.Log("Hello im a " + CurrentGuest.Role.ToString());
        
    }

    public People GetCurrentGuest()
    {
        return PeopleList[PeopleList.Count-1];
    }

	public void HandleGreetings(Greetings PlayerGreeting)
    {
        if (PlayerGreeting == GetCurrentGuest().WantedGreeting)
        {
            CurrentGuest.SetGreetedRight(true);
        }
        else
        {
            CurrentGuest.SetGreetedRight(false);
        }

        Timer.EndTimer();
        CurrentGuest.SetGreetingTime(Timer.Time);
        StartCoroutine(LogList());
        AnimationController.CloseDoor();
        CurrentGameState = GameState.OpenDoor;
    }

    public IEnumerator ChangeGamestate(GameState GameState)
    {
        while(true)
            {
                    if (AnimationController.playing == false)
                    {
                      CurrentGameState = GameState;
                    }
            yield return null;
        }
        
    }

	void Update () {
		
	}
}
