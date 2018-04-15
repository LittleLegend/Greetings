using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    public Animator Doorstep_Animator;
    public bool playing;
    
    void Update()
    {
        if(Doorstep_Animator.GetCurrentAnimatorStateInfo(0).IsName("Door_Open_Still")
            || Doorstep_Animator.GetCurrentAnimatorStateInfo(0).IsName("Door_Close_Still"))
        {
            playing = false;

        }
        else { playing = true; }
        
    }

   
    public void OpenDoor()
    {
        playing = true;
        Doorstep_Animator.SetBool("DoorOpen", true);
    }

    public void CloseDoor()
    {
        playing = true;
        Doorstep_Animator.SetBool("DoorOpen", false);
    }

}
