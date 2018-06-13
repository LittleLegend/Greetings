using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Enums;

public class UIController : MonoBehaviour {

    public References References;
    public StateMachine StateMachine; 
    public TextMeshProUGUI ComboLabel;
    public TextMeshProUGUI PointLabel;
    
    
    public void Start()
    {
        StateMachine = References.StateMachine;
    }

    public void SetPointLabel(int points)
    {
        PointLabel.text =  points.ToString(); 
    }

    public void SetComboLabel(int combo)
    {
        ComboLabel.text = "x"+combo.ToString();
    }

    public void OpenDoorButton(int ButtonTrigger)
    {
        if (ButtonTrigger == 0)
        {

        }
        else
        {

            StateMachine.CurrentGameState = GameState.OpenDoor;
        }

    }
}
