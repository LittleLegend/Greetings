using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Doorstep : MonoBehaviour {

    
    public Player Player;
    
    public PeopleFactory PeopleFactory;
    
    public List<People> PeopleList;
    
    public People CurrentGuest;
    
    public Animator Doorstep_Animator;
    
    public AnimationController AnimationController;

    public InputController InputController;

    public Timer Timer;
    
    public GameState CurrentGameState;
    
    public GestureFactory GreetingFactory;

 
    void Start () {

        PeopleList = new List<People>();
        PeopleFactory = new PeopleFactory();
        GreetingFactory = new GestureFactory(this);
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

            HandleGreetings(null);
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
        CurrentGuest = PeopleFactory.createWife();
        CurrentGuest.WantedGreeting = GreetingFactory.createGreeting(CurrentGuest.Type);
        PeopleList.Add(CurrentGuest);

        Timer = new Timer();
        AnimationController.OpenDoor();
        CurrentGameState = GameState.InputGreeting;

        
        StartCoroutine(CheckForTimeout());
        StartCoroutine(Timer.StartTimer(CurrentGuest.MaxGreetingTime));

        Debug.Log("Hello im a " + CurrentGuest.Type.ToString());
        
    }

    public void EndGreetTime()
    {
        AnimationController.CloseDoor();
        AnimationController.EnableScene(false);
        AnimationController.PlayScene(Scenes.Still_0);
        CurrentGameState = GameState.OpenDoor;

    }
    

	public void HandleGreetings(Greetings PlayerGreeting)
    {
        
            if (PlayerGreeting == CurrentGuest.WantedGreeting)
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
        CurrentGameState = GameState.WatchScene;
        AnimationController.EnableScene(true);
        AnimationController.PlayScene(Scenes.Wife_Kiss_1);
        
      
    }

	void Update () {
		
	}
}
