using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class GestureFactory{

    public Doorstep Doorstep;
    public Player Player;
    public List<Gesture> GestureList;

   public GestureFactory(Doorstep Doorstep, Player Player)
    {
        this.Doorstep = Doorstep;
        this.Player = Player;
    }

    public List<Gesture> createGestureList()
    {
        GestureList = new List<Gesture>();
        GestureList.Add(createBump());
        GestureList.Add(createShake());
        GestureList.Add(createKiss());
        GestureList.Add(createHug());

        return GestureList;
    }

    public Kiss createKiss()
    {
        return new Kiss(Doorstep,Player);
    }
    public Bump createBump()
    {

        return new Bump(Doorstep, Player);
    }
    public Shake createShake()
    {

        return new Shake(Doorstep, Player);
    }
    public Hug createHug()
    {
        return new Hug(Doorstep, Player);
    }

    public None createNone()
    {
        return new None(Doorstep, Player);
    }

}
