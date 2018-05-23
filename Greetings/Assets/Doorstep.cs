using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Doorstep : MonoBehaviour {

    
    public Player Player;

    public Camera Camera;

    public PeopleFactory PeopleFactory;
    
    public List<People> PeopleList;
    
    public People CurrentGuest;
    
    public Animator Doorstep_Animator;
    
    public AnimationController AnimationController;

    public InputController InputController;

    public Timer Timer;
    
    public GameState CurrentGameState;
    
    public GestureFactory GestureFactory;

    public DataManager DataManager;

    public UIView UIView;

     int points = 0;

 
    void Start () {


        PeopleList = new List<People>();
        PeopleFactory = new PeopleFactory(DataManager);
        GestureFactory = new GestureFactory(this,Player);

        DataManager.Load();

        InputController.GestureList = GestureFactory.createGestureList();

        Player.resetGreetCommand();
        
        CurrentGameState = GameState.OpenDoor;

        StartCoroutine(changeGuest(0));

        UIView.SetPointLabel(points);
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
        CurrentGameState = GameState.InputGreeting;
        
        Timer = new Timer();
        
        AnimationController.OpenDoor();
        AnimationController.SetClock(1, CurrentGuest.MaxGreetingTime);
        AnimationController.guestChanged = false;
        InputController.startInputGreeting();
        
        StartCoroutine(CheckForTimeout());
        StartCoroutine(Timer.StartTimer(CurrentGuest.MaxGreetingTime));

        Debug.Log("Hello im a " + CurrentGuest.Type.ToString());
        
    }

    public void EndGreetTime()
    {
        
        AnimationController.CloseDoor();
        AnimationController.SetClock(0, 0);
        AnimationController.EnableScene(false);
        AnimationController.ResetScene();
        CurrentGameState = GameState.OpenDoor;
        StartCoroutine(changeGuest(0.1f));
    }
    
    public IEnumerator changeGuest(float delay)
    {
        yield return new WaitForSeconds(delay);

        while (Player != null)
        {
            if (AnimationController.playing == false)
            {

                CurrentGuest = PeopleFactory.createRandom(points);
                PeopleList.Add(CurrentGuest);
                AnimationController.SetGuest(CurrentGuest.Type);
                yield return new WaitForSeconds(delay);
                AnimationController.guestChanged = true;
                break;
            }
            yield return null;
        }
    }

	public void HandleGreetings(Greetings PlayerGreeting)
    {
        Debug.Log(PlayerGreeting);
            if (PlayerGreeting == CurrentGuest.WantedGreeting)
            {
                CurrentGuest.SetGreetedRight(true);
                points += CurrentGuest.points;
                UIView.SetPointLabel(points);
        }
            else
            {
                CurrentGuest.SetGreetedRight(false);
                points = 0;
                UIView.SetPointLabel(points);
        }
        

        Timer.EndTimer();

        CurrentGuest.SetGreetingTime(Timer.Time);

        StartCoroutine(LogList());

        CurrentGameState = GameState.WatchScene;
        
        InputController.startWatchScene();

        AnimationController.PlaySceneRole(CurrentGuest,PlayerGreeting);
        AnimationController.EnableScene(true);
       
        
      
    }

	void Update () {
		
	}
}
