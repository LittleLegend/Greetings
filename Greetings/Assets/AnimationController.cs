using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class AnimationController : MonoBehaviour {

    public Animator Doorstep_Animator;
    public Animator Guest_Animator;
    public Animator Scene_Animator;
    public Animator Clock_Animator;
    public SpriteRenderer SceneRenderer;
    public SpriteRenderer GreetingRenderer;
    public bool playing;
    public bool sceneEnded;
    public bool guestChanged;

    void Update()
    {
            SetSceneEnded();
            SetPlaying();
        
    }

    public void SetClock(int running, float seconds)
    {
        Clock_Animator.SetInteger("Running", running);
        Clock_Animator.SetFloat("Speed", 5/seconds);

    }

    public void SetGuest(Roles Role)
    {
        switch (Role)
        {
            case Roles.Wife:
                Guest_Animator.SetInteger("Guest", 1);
                break;

            case Roles.Friend:
                Guest_Animator.SetInteger("Guest", 2);
                break;

            case Roles.Boss:
                Guest_Animator.SetInteger("Guest", 3);
                break;
                
            case Roles.Mother:
                Guest_Animator.SetInteger("Guest", 4);
                break;
        }
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

    public void EnableScene(bool Enabled)
    {
        {
            SceneRenderer.enabled = Enabled;
           GreetingRenderer.enabled = Enabled;

        }
    }

    public void ResetScene()
    {
        Scene_Animator.SetInteger("Scene", 0);
    }

    public void PlaySceneRole(Roles GuestType, Greetings PlayerGreeting)
    {
        switch(GuestType)
        {
            case Roles.Wife:

                PlaySceneWife(PlayerGreeting);

                break;

            case Roles.Boss:

                PlaySceneBoss(PlayerGreeting);

                break;

            case Roles.Friend:

                PlaySceneFriend(PlayerGreeting);

                break;

            case Roles.Mother:

                PlaySceneMother(PlayerGreeting);

                break;

        }
    }
    public void PlaySceneWife(Greetings PlayerGreeting)
    {
        switch (PlayerGreeting)
        {
            case Greetings.Kiss:

                Scene_Animator.SetInteger("Scene", 1);

                break;

            case Greetings.Bump:

                Scene_Animator.SetInteger("Scene", 2);

                break;

            case Greetings.Hug:

                Scene_Animator.SetInteger("Scene", 2);

                break;

            case Greetings.Shake:

                Scene_Animator.SetInteger("Scene", 2);

                break;

            case Greetings.None:

                Scene_Animator.SetInteger("Scene", 2);

                break;

        }

    }
    public void PlaySceneFriend(Greetings PlayerGreeting)
    {
        switch (PlayerGreeting)
        {
            case Greetings.Kiss:

                Scene_Animator.SetInteger("Scene", 4);

                break;

            case Greetings.Bump:

                Scene_Animator.SetInteger("Scene", 3);

                break;

            case Greetings.Hug:

                Scene_Animator.SetInteger("Scene", 4);

                break;

            case Greetings.Shake:

                Scene_Animator.SetInteger("Scene", 4);

                break;

            case Greetings.None:

                Scene_Animator.SetInteger("Scene", 4);

                break;

        }

    }
    public void PlaySceneMother(Greetings PlayerGreeting)
    {
        switch (PlayerGreeting)
        {
            case Greetings.Kiss:

                Scene_Animator.SetInteger("Scene", 6);

                break;

            case Greetings.Bump:

                Scene_Animator.SetInteger("Scene", 6);

                break;

            case Greetings.Hug:

                Scene_Animator.SetInteger("Scene", 5);

                break;

            case Greetings.Shake:

                Scene_Animator.SetInteger("Scene", 6);

                break;

            case Greetings.None:

                Scene_Animator.SetInteger("Scene", 6);

                break;

        }

    }
    public void PlaySceneBoss(Greetings PlayerGreeting)
    {
        switch (PlayerGreeting)
        {
            case Greetings.Kiss:

                Scene_Animator.SetInteger("Scene", 8);

                break;

            case Greetings.Bump:

                Scene_Animator.SetInteger("Scene", 8);

                break;

            case Greetings.Hug:

                Scene_Animator.SetInteger("Scene", 8);

                break;

            case Greetings.Shake:

                Scene_Animator.SetInteger("Scene", 7);

                break;

            case Greetings.None:

                Scene_Animator.SetInteger("Scene", 8);

                break;

        }

    }

    public void  SetPlaying()
    {
            if (Doorstep_Animator.GetCurrentAnimatorStateInfo(0).IsName("Door_Open_Still")
               || Doorstep_Animator.GetCurrentAnimatorStateInfo(0).IsName("Door_Close_Still")
               )
            {
                playing = false;

            }
            else { playing = true; }
            
    }

    public void SetSceneEnded()
    {
            if ( Scene_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                sceneEnded = true;
                playing = true;
        }
            else { sceneEnded = false; }
        
    }


}
