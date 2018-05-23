using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIView : MonoBehaviour {

    public TextMeshProUGUI PointLabel;

    public void SetPointLabel(int points)
    {
        PointLabel.text =  points.ToString(); 
    }

}
