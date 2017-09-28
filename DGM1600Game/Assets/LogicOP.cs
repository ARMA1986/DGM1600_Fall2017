using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// LOGIC OPERATORS EXPLANATION

// Logic operators become really useful when analyzing conditions, many times we gotta work
// the logic part of it in our brains to figure out what we want to accomplish under which 
// conditionals. Logic operators help connect two or more conditions and evaluates them to
// perform a funcion. The boolean variable only has two states, true or false, so it only 
// evaluates these two; however it is possible to have a second variable to be evaluated in
// the same conditional statement. Logic operators mainly establish a relation between variables
// being evaluated on the same conditional statement. And else statement is important to have at
// the end to correct/anticipate any other invalid entries.


public class LogicOP : MonoBehaviour {

	public string luke = "Jedi";

	public string vader = "Sith";

	public bool leia = true;

	public string darkSide = "Darth Maul";

	public string lightSide = "Obi Wan";

	public bool r2D2 = false;

	public string theForce = "Star Wars";

	public string theFourth = "May";

	public int movies = 5;

	public string lastTime = "This year";

	// Use this for initialization
	void Start () {
		if(luke=="Jedi" && vader == "Nanny"){
			print("Vaders yo Naddy!");
		}
		else if (luke =="Jawa" && vader=="Sith"){
			print("Ultini!");
		}
		else if (luke=="Jedi" && vader == "Sith"){
			print("Nooooooooo! That's not true . . . That's impossible!");
		}
		else{
			print("The End!");
		}
		
		if(leia){
			print("No, there is another.");
		}
		else if(!leia){
			print ("Hoorray! Now I can date Luke");
		}
		else{
			print("Han fired first!");
		}
		
		if(lightSide=="Obi Wan" || darkSide == "Jar Jar Binks"){
			print("Meeeza Evil Bad Bad Sith Lorda");
		}
		else if (lightSide == "Boba Fett" || darkSide == "Darth Maul"){
			print("As you wish, my master");
		}
		else{
			print("Not the younglings!");
		}

		if(r2D2){
			print("I am not the real r2D2");
		}
		else if(!r2D2){
			print("turututurutu");
		}

		if(theForce=="Star Wars" && theFourth != "May"){
			print("May the Force be with you!");
		}
		else if (theForce !="Star Wars" && theFourth=="May"){
			print("May the Fourth be with you.");
		}
		else if (theForce!="Star Wars" || theFourth == "May"){
			print("You are not a true Star Wars fan");
		}
		else{
			print("The End!");
		}

		if(movies==5 && lastTime == "This year"){
			print("You have watched at least 5 Star Wars movies and the last time you watched one was this year");
		}
		else if (movies <5 && lastTime=="This Year"){
			print("You have some catching up to do ");
		}
		else{
			print("You are nowhere near to be a Star Wars maniac");
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
