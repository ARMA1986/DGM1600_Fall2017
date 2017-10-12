using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// From what I understood, List allows you to call upon an eternal class or script and makes it
// so that we can access and pass functions and variables through that other class. The operator
// "Add" added items to the list amd it was expecting the parameters determined on the external
// class. 

// The Foreach command allows a common variable within a certain group or list to be evaluated
// and have a code ran through it . In other words: For each item in a list, a function will 
// be executed.


public class ForEach_List : MonoBehaviour {
	
	List<FirstOrder> badguys= new List<FirstOrder>();
	List<FirstOrder> goodguys= new List<FirstOrder>();
	List<FirstOrder> groceries= new List<FirstOrder>();

	// Use this for initialization
	void Start () {

		badguys.Add(new FirstOrder("Snoke",1000));
		badguys.Add(new FirstOrder("General Hux",20));
		badguys.Add(new FirstOrder("Kylo Rem",440));
		badguys.Add(new FirstOrder("Captain Phasma",150));
		
		badguys.Sort();

		foreach(FirstOrder guy in badguys){
			print(guy.name+" "+guy.power);
		}

		goodguys.Add(new FirstOrder("Anakin Skywalker",1000));
		goodguys.Add(new FirstOrder("Yoda",2000));
		goodguys.Add(new FirstOrder("Han Solo",500));
		goodguys.Add(new FirstOrder("C-3PO",10));
		
		goodguys.Sort();

		foreach(FirstOrder guy in goodguys){
			print(guy.name+" "+guy.power);
		}

		groceries.Add(new FirstOrder("Tomatoes $",5));
		groceries.Add(new FirstOrder("Onions $",3));
		groceries.Add(new FirstOrder("Lettuce $",1));
		groceries.Add(new FirstOrder("Lemons $",2));
		groceries.Add(new FirstOrder("Celery $",1));

		groceries.Sort();

		foreach(FirstOrder grocery in groceries){
			print(grocery.name+" "+grocery.power);
		}



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
