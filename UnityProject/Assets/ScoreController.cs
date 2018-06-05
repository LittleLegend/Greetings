using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController{

     int combo;
     int points;
    public List<People> PeopleList;
    public UIController UIController;

    public ScoreController(UIController UIController)
    {
        this.UIController = UIController;
        PeopleList = new List<People>();
    }

	public void SetCombo(int combo)
    {
        this.combo = combo;
        UIController.SetComboLabel(combo);
    }

    public void SetPoints(int points)
    {
        this.points = points;
        UIController.SetComboLabel(points);
    }

    public int GetCombo()
    {
        return combo;
    }

    public int GetPoints()
    {
        return points;
    }

    public void AddCombo(int combo)
    {
        this.combo += combo;
        UIController.SetComboLabel(combo);
    }

    public void AddPoints(int points)
    {
        this.points += points;
        UIController.SetComboLabel(points);
    }

     public void ResetCombo()
    {
        combo = 0;
        UIController.SetComboLabel(combo);
    }

}
