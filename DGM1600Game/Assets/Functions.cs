using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {


	// Function is like a miachine. Stuff goes into the machine and other stuff comes out. It 
	// essentially is a method that has an specific task. System functions run automatically but
	// custom functions only run upon being called. After a function we include "()" to stablish
	// the argument, passing stuff into the machine. We can think of a function as a blender and 
	// the argument as the ingredients.


	public int laserBlast;


	// Use this for initialization
	void Start () {
		DeathStar(laserBlast);
		Luke(laserBlast);
		Yoda(laserBlast);
		ObiWan(laserBlast);
		Chewbacca(laserBlast);
		C3po(laserBlast);
		R2d2(laserBlast);
		PrincessLeia(laserBlast);
		DarthVader(laserBlast);
		HanSolo(laserBlast);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DeathStar (int vent){
		print("That's no moon, that's a space station!");
		print(vent);
		if(vent==1){
			print("Porkin's misses the mark");
		}
		else if(vent==2){
			print("Red leader misses");
		}
		else{
			print("Death Star blows up!");
		}
	}

	void Luke (int weapon){
		print("Luke will use :");
		if(weapon==1){
			print("his light saber");
		}
		else if(weapon==2){
			print("his laser gun");
		}
		else if(weapon==3){
			print("his fists");
		}
		else{
			print("the force!");
		}
	}

	void Yoda (int advice){
		print("Yoda says:");
		if(advice==1){
			print("Fear is the path to the dark side. Fear leads to anger. Anger leads to hate.");
		}
		else if(advice==2){
			print("Death is a natural part of life. Rejoice for those around you who transform into the Force.");
		}
		else{
			print("Mmmhmm...");
		}
	}

	void ObiWan(int advice){
		print("Obi Wan Kenobi says:");
		if(advice==1){
			print("Luke, you’re going to find that many of the truths we cling to depend greatly on our own point of view.");
		}
		else if(advice==2){
			print("Use the Force, Luke.");
		}
		else{
			print("Mmmhmm...");
		}
	}

	void Chewbacca(int advice){
		print("Chewbacca says:");
		if(advice==1){
			print("Ummmm...");
		}
		else if(advice==2){
			print("Ahhhhrrrr...");
		}
		else{
			print("Aaarhhggg...");
		}
	}

	void C3po(int advice){
		print("C-3PO comments :");
		if(advice==1){
			print("R2-D2, where are you?");
		}
		else if(advice==2){
			print("R2-D2, it is you, It Is You?");
		}
		else{
			print("Don't you call me a mindless philosopher you overweight glob of grease!");
		}
	}

	void R2d2(int advice){
		print("R2-D2 says :");
		if(advice==1){
			print("Beep Beep Blop");
		}
		else if(advice==2){
			print("Beep Beep Blop Bleep");
		}
		else{
			print("Beep Blop Bleep Bleep");
		}
	}

	void PrincessLeia(int advice){
		print("Princess Leia says :");
		if(advice==1){
			print("Help me Obi-Wan Kenobi, you’re my only hope.");
		}
		else if(advice==2){
			print("Aren’t you a little short for a stormtrooper?");
		}
		else{
			print("You know, no matter how much we fought, I always hated watching you leave.");
		}
	}

	void DarthVader(int advice){
		print("Darth Vader says :");
		if(advice==1){
			print("Luke! I am your father!");
		}
		else if(advice==2){
			print("I find your lack of faith disturbing");
		}
		else{
			print("When I left you I was but the learner. Now I am the master.");
		}
	}

	void HanSolo(int advice){
		print("Han Solo says :");
		if(advice==1){
			print("Great, kid. Don't get cocky");
		}
		else if(advice==2){
			print("Laugh it up, fuzzball!");
		}
		else{
			print("Chewie, we're home.");
		}
	}

}
