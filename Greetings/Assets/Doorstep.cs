using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorstep : MonoBehaviour {

	public Player Player;
    public PeopleFactory PeopleFactory;
    public List<People> PeopleList;


	void Start () {

        PeopleList = new List<People>();
        PeopleFactory = new PeopleFactory();

        PeopleList.Add(PeopleFactory.createRandom());


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
