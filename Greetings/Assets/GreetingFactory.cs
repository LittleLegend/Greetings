using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class GestureFactory{

    public Doorstep Doorstep;
    public List<Gesture> GestureList;

   public GestureFactory(Doorstep Doorstep)
    {
        this.Doorstep = Doorstep; 
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
        return new Kiss(Doorstep);
    }
    public Bump createBump()
    {

        return new Bump(Doorstep);
    }
    public Shake createShake()
    {

        return new Shake(Doorstep);
    }
    public Hug createHug()
    {
        return new Hug(Doorstep);
    }

}
