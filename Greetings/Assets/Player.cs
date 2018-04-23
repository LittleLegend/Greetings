using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Player: MonoBehaviour {

    [SerializeField]
    public Doorstep Doorstep;

    [SerializeField]
    public InputController InputController;

    public ICommand Greet;
   
    
    public void setGreet(IGesture Gesture)
    {
        Greet = new GreetCommand(Gesture);
    }

    public void greet()
    {
        Greet.execute();
    }

    public void Shake()
    {
        
        Doorstep.HandleGreetings(Doorstep.GreetingFactory.createShake());
    }
    public void Hug()
    {
        Doorstep.HandleGreetings(Doorstep.GreetingFactory.createHug());
    }

    public void Kiss()
    {
        Doorstep.HandleGreetings(Doorstep.GreetingFactory.createKiss());
    }

    public void Bump()
    {
        Doorstep.HandleGreetings(Doorstep.GreetingFactory.createBump());
    }
    
    public void OpenDoor()
    {
        Doorstep.StartGreetTime();
    }

    public void CloseDoor()
    {
        Doorstep.EndGreetTime();
    }

}
