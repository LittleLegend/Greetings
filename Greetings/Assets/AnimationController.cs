using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class AnimationController : MonoBehaviour {

    public Animator Doorstep_Animator;
    public Animator Scene_Animator;
    public SpriteRenderer SceneRenderer;
    public SpriteRenderer GreetingRenderer;
    public bool playing;
    public bool sceneEnded;

    void Update()
    {
        
            SetSceneEnded();
            SetPlaying();
        
        
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

    public void PlayScene(Scenes Scene)
    {
        switch(Scene)
        {
            case Scenes.Wife_Kiss_1:

                Scene_Animator.SetInteger("Scene", 1);

                break;

             case Scenes.Still_0:

                Scene_Animator.SetInteger("Scene", 0);

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
            }
            else { sceneEnded = false; }
        
    }


}
