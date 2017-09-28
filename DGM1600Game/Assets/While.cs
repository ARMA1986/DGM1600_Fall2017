using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour {

//	WHILE LOOPS EXPLANATION 
//
// While loops seem to work good with numeric data. They repeat an specified function
// while the conditional is true. It works good with increments and decrements as we 
// used in our samples. One must be careful because they can crash the program if the 
// while loop is set to an infinite loop. We have to consider the negative numbers when
// stating a conditional, we cannot just assume that the loop will stop at 0. An easy way
// to avoid this logic errors is by making sure we are stablishing parameters on both ends.
// That can be achieved with the "&&" when setting the parameters in the conditional, 
// that will help state that the variable is less than a number AND greater than another number.
// Another thing regarding logic errors or just aesthetics is to make sure we are using proper 
// grammar and end the loop right before the variable is 1 or 0, in which case we may have to
// just add another statement out of the loop to correctly conjugate or spell in singular; or
// just state something that makes more sense according to the variable quantity. 

	public int bottles = 0;
	public int temp = 100;
	public int heater = 76;
	public decimal money = 10.00m;
	public decimal bankAcc = 500.00m;

	public int ammo = 200;
	public int health = 0;
	public int enemies = 10;
	public int characters = 5;
	public int daysLeft= 30;

	// Use this for initialization
	void Start () {
		// while(bottles<100){
		// 	print(bottles + " bottles of beer on the wall!");
		// 	bottles ++;
		// }
		
		// while(temp>72){
		// 	print("The current temperature is " + temp + ". AC will remain on.");
		// 	temp--;
		// }

		// while(heater>0){
		// 	print("It's chilly here, the temp is " + heater + ". The furnace will stay on.");
		// 	heater--;
		// }
	
		// while(money>0){
		// 	print("I have $ " + money + " in my wallet.");
		// 	money--;
		// }
	
		// while(bankAcc>-1){
		// 	print("You have $" + bankAcc + " dollars remaining in your deposit account.");
		// 	bankAcc-=100;
		// }
	
		// while(ammo>-1){
		// 	print("You have " + ammo + " bullets left.");
		// 	ammo-=50;
		// }

		// while(health<=100){
		// 	print("You're health is " + health + ". Warhog armor is aiding you.");
		// 	health+=10;
		// }

		// while(enemies>1){
		// 	print("Look for the enemies. There are " + enemies + " enemies hidden.");
		// 	enemies--;
		// }
		// print("Look for the enemies. There is " + enemies + " enemy hidden.");

		// while(characters<6 && characters>1){
		// 	print("You have " + characters + " seconds left to choose a character.");
		// 	characters--;
		// }
		// print("You have " + characters + " second left to choose a character.");
		// print("Your time is up! A character has been randomly chosen for you.");

		while(daysLeft>0){
			print("There are " + daysLeft + " days left on this month.");
			daysLeft-=5;
		}
		print ("Today is the last day of the month!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
