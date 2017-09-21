using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public string[] heroes= new string[6];

	// public RedShop[]inventory= new RedShop[6];
	// inventory [0]= health potion;
	// inventory [1]= mana potion;
	// inventory [2]= reload ammo;
	// inventory [3]= repair armor;
	// inventory [4]= hire warrior; 
	// inventory [5]= rent vehicle;

	// Use this for initialization
	void Start () {



	heroes [0]="Batman";
	heroes [1]="Superman";
	heroes [2]="Flash";
	heroes [3]="Hulk";
	heroes [4]="Wonder Woman";
	heroes [5]="Wolverine";

	print(heroes[0]);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
