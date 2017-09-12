using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional : MonoBehaviour {

public string stopLight = "Red";

void Start(){
	Main();
}
/* For the Homework 

// Creating Else clauses

public int health = 100;

void Main(){
	// This conditional will tell the player the health is full
	if ( health == 100){
		print("Full Health. Unable to be healed!");
	}
	// This conditional will tell the player the health has decreased
	else if (health == 80){
		print("Your health has decreased a little");
	}
	//	This conditional will tell the player the health is half way gone
	else if (health == 60){
		print("Almost half life is gone!");
	}
	//	This conditional will suggest that healing needs to happen quickly
	else if (health == 40){
		print("You need to heal fast");
	}
	//	This conditional will tell the player he is about to die
	else if (health == 20){
		print("Almost dead!");
	}
	//	This conditional will tell the player he is dead
	else if (health == 0){
		print("You are dead!");
	}
	//	This conditional will tell the player the health status will be displayed soon
	else{
		print("Your health status will be displayed soon");
	}
}

 */


void Main(){
	if ( stopLight == "Red"){
		print("STOP! The light is red !");
	}
	else if (stopLight == "Yellow"){
		print("Slow Down!");
	}
	else if (stopLight == "Green"){
		print("Go!");
	}
	else {
		print("I don't know what you mean!");
	}
}
}
