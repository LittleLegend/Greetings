﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using System;

public class Bump : Gesture
{
    public Bump(Doorstep Doorstep,Player Player)
    {
        this.Doorstep = Doorstep;
        this.Player = Player;
    }

    public override void greet()
    {
        Doorstep.HandleGreetings(Greetings.Bump);
    }

    public override void checkInput()
    {
        Vector3 screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        screenPoint = Doorstep.Camera.ScreenToViewportPoint(screenPoint);

        if (Input.GetMouseButton(0)
             && screenPoint.x >= 0
             && screenPoint.y <= 0)
        {
            Player.setGreetCommand(this);
        }
    }

    public override void undoGreet()
    {
        Doorstep.PeopleList.RemoveAt(Doorstep.PeopleList.Count - 1);
    }
}
