using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Arrays are a kind of variable that serves as a container for smaller components/items.
// It allows you to group alike items into a common variable. That common variable has certain
// amount of spots or placeholders that get declared. Then to use that array, you can use that
// array variable, that gets to be called by name, and use the number of its "placeholder"
// and the information stored in it wil become avaiable. The way the array syntax is broken
// into is (variable indicator (public/private), then type of variable/array (int, string, float
// double, etc...), then we must include brackets "[]" indicating that it wasn't a simple variable,
// but an array instead. Then we assign the number of items this array may hold with "= new (type of
// array) [#]" with the quantity of items we wish the array to have replacing the "#" sign, ending the statement as
// usual with a semicolon ";")


public class Arrays : MonoBehaviour {

	public string[] heroes= new string[6];

	public string[]inventory= new string[6];

	public int[] Health_Percentage = new int[5];

	public float[] Ammo_Percentage = new float[5];

	public string[] bosses= new string[3];

	public string[] Enemies= new string[6];

	public string[] Back_Pack= new string[6];

	public int[] Number_Keys = new int[5];

	public float[] Level_Complete = new float[5];

	public string[] Difficulty= new string[3];

	
	// Use this for initialization
	void Start () {
	
	bosses [0]="Doom";
	bosses [1]="Green Goblin";
	bosses [2]="Loki";
	
	print("The villain you get to face is "+ bosses[2]);

	Health_Percentage [0]=0;
	Health_Percentage [1]=25;
	Health_Percentage [2]=50;
	Health_Percentage [3]=75;
	Health_Percentage [4]=100;

	print(Health_Percentage [4]+"%");

	Ammo_Percentage [0]=0f;
	Ammo_Percentage [1]=.25f;
	Ammo_Percentage [2]=.5f;
	Ammo_Percentage [3]=.75f;
	Ammo_Percentage [4]=1.0f;

	print(Ammo_Percentage [4]+" bullet cartridge left");

	heroes [0]="Batman";
	heroes [1]="Superman";
	heroes [2]="Flash";
	heroes [3]="Hulk";
	heroes [4]="Wonder Woman";
	heroes [5]="Wolverine";

	print(heroes[0]);
	
	inventory [0]= "health potion";
	inventory [1]= "mana potion";
	inventory [2]= "reload ammo";
	inventory [3]= "repair armor";
	inventory [4]= "hire warrior"; 
	inventory [5]= "rent vehicle";

	print(inventory[3]);

	Enemies [0]="red guy";
	Enemies [1]="blue guy";
	Enemies [2]="yellow guy";
	Enemies [3]="gray guy";
	Enemies [4]="purple guy";
	Enemies [5]="green guy";

	print("You are now facing: " + Enemies[1] + ", " + Enemies [3] + " and " + Enemies[5]);

	Back_Pack [0]="weapon";
	Back_Pack [1]="stim pack";
	Back_Pack [2]="medicine";
	Back_Pack [3]="keys";
	Back_Pack [4]="artifact";
	Back_Pack [5]="map";

	print("You have chosen to check your " + Back_Pack[0]);

	Number_Keys [0]=0;
	Number_Keys [1]=1;
	Number_Keys [2]=2;
	Number_Keys [3]=3;
	Number_Keys [4]=4;

	print("You have " + Number_Keys [4] + " keys.");
	
	Level_Complete [0]=0;
	Level_Complete [1]=.25f;
	Level_Complete [2]=.50f;
	Level_Complete [3]=.75f;
	Level_Complete [4]=1.00f;

	print("The level is " + Level_Complete [3]+" completed.");

	Difficulty [0]="Rookie";
	Difficulty [1]="Experienced";
	Difficulty [2]="Veteran";

	print("The difficulty will be set for a " + Difficulty[0] + " player.");

	}
	// Update is called once per frame
	void Update () {
		
	}
}
