using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRubyShared;

public class GestureAdapter{

    FingersScript FingersScript;
    TapGestureRecognizer tapgesture;

    public GestureAdapter(FingersScript fingersScript)
    {
        FingersScript = fingersScript;
    }
    
    void Start () {
		
	}
	
    public void CreateTab(GestureRecognizerStateUpdatedDelegate gestureRecognizerStateUpdatedDelegate)
    {
        tapgesture = new TapGestureRecognizer();
        tapgesture.StateUpdated += gestureRecognizerStateUpdatedDelegate;
        FingersScript.AddGesture(tapgesture);
        
    }
    public void RemoveTab()
    {
        FingersScript.RemoveGesture(tapgesture);
    }

}
