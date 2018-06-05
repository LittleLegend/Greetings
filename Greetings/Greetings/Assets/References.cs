using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class References : MonoBehaviour {

    
    public Player Player;

    public Camera Camera;

    public PeopleFactory PeopleFactory;
    
    public Animator Doorstep_Animator;
    
    public AnimationController AnimationController;

    public InputController InputController;
    
    public DataManager DataManager;

    public UIController UIController;

    public StateMachine StateMachine;

    public ScoreController ScoreController;

    public GestureFactory GestureFactory;
    
    void Start () {

        Player = new Player(StateMachine);
        PeopleFactory = new PeopleFactory(DataManager);
        GestureFactory = new GestureFactory(Player,StateMachine);
        ScoreController = new ScoreController(UIController);
        InputController = new InputController(Camera, Player);

    }
     
}
