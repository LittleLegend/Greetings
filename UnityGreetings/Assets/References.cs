using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using DigitalRubyShared;

public class References : MonoBehaviour {

    
    
    public Camera Camera;

    public PeopleFactory PeopleFactory;
    
    public Animator Doorstep_Animator;
    
    public AnimationController AnimationController;

    public InputController InputController;
    
    public DataManager DataManager;

    public UIController UIController;

    public StateMachine StateMachine;

    public ScoreController ScoreController;
    
    public FingersScript FingersScript;

    public GestureAdapter GestureAdapter;

    
    void Start () {
        
        PeopleFactory = new PeopleFactory(DataManager);
        ScoreController = new ScoreController(UIController);
        GestureAdapter = new GestureAdapter(FingersScript);
        InputController = new InputController( GestureAdapter,StateMachine);

    }
     
}
