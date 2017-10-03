using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Loop : MonoBehaviour {

	//	FOR LOOP
	//
	// For loop is another way to use loops. It basically says that the method will work for
	// a defined parameter. The syntax of the code for a FOR LOOP has a certain order, it has three 
	// divisions where semicolons divide the parts. The normal syntax is declaring a variable and 
	// giving it a value ";", then the parameters ";" and then the increment or decrement type. This
	// whole syntax is enclosed in parenthesis and at the end you open brackets
	// to declare the method that is going to be running for such a loop.
	// For loops work with digits as the parameters need to be finite and the increments will be
	// by a determine amount which in conjuction with the parameters, it will dictate the number 
	// of times the code will run.
	
	
	public int num = 100;

	// Use this for initialization
	void Start () {
		
		while(bottles > 0){
			print(bottles+ " of orange crush on the wall");
			bottles --;
		}

		for(;num>9; num-=10){
			print(num+ " bottles of orange crush on the wall");
		}
		for(;num<11;num++){
			print(num+ " little monkeys jumping on the bed");
		}


		for(int age=100;age>88;age-=2){
			print("Grandma, are you "+age+ " years old?");
		}
		for(int valu = 50 ;valu > -1;valu-=10){
			print("I have "+valu+" bullets left");
		}

		for(int car=1000;car>400;car-=100){
			print("We have "+car+" cars left in this dealer.");
			for(;car>-1;car-=100){
				print("We are getting low, we have now " +car+" vehicles left. ");
			}
		}

		for(int nursery= 25; nursery>0;nursery-=5){
			print("we have only "+nursery+" songs in our playlist.");
		}

		for(int chickens=1; chickens<11;chickens++){
			print("Mama chicken just had another baby, there are " +chickens +" chickens now in the coop");
		}

		for(int hero=1; hero<11 ; hero++){
			print("Another hero has joined your party. There are a total of " +hero+" heroes now.");
		}

		for(int arena=5; arena>0 ; arena--){
			print("All players are selecting their arena. There are " + arena + " worlds you can still go into.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
