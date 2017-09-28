using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public string townCenter;
	public string phoneProvider;
	public int age;
	public int cars;
	public int children;
	public string degree;
	public string sport;
	public string movieType;
	public int pets;
	public string anime;


	// Use this for initialization
	void Start () {
		switch(townCenter){
			case "main": 
				print("Welcome to Main Street!");
			break;
			case "blacksmith":
				print("The blacksmith grumbles as you pick through the sword bin");
			break;
			case "bakery":
				print("Mmmmmmmmm hot buttery buns");
			break;
			case "morgue":
				print("Peeeeeeyew!");
				break;
			default:
				print("I don't know what you're talking about!");
				break;
			}

		switch(phoneProvider){
			case "verizon":
				print("You'll have good signal");
			break;
			case "tmobile":
				print("You'll probably be okay as long as you stay near main street");
			break;
			case "sprint":
				print("You may want to get a different provider or just turn your phone off");
			break;
			default:
				print ("You entered an invalid entry or your phone company sucks");
			break;

		}

		switch(cars){
			case 3:
				print("You are rich or you have a dealer.");
			break;
			case 2:
				print("You probably share one of them");
			break;
			case 1:
				print("You are like the average adult in Utah");
			break;
			case 0:
				print("Poor you.");
			break;
			default:
				print ("You didn't enter a number or you have a dealer");
			break;

		}

		switch(age){
			case 5:
				print("You are pretty smart to be using this device");
			break;
			case 10:
				print("You are about to go to junior high");
			break;
			case 15:
				print("Two more years and you are out of high school");
			break;
			case 20:
				print("You are almost old enough to drink!...legally");
			break;
			default:
				print ("You are an old fart");
			break;
		}

		switch(children){
			case 3:
				print("Try not to have anymore if you want to have quality time with them");
			break;
			case 2:
				print("Good job! Children are blessings!");
			break;
			case 1:
				print("Gotta get your child a partner in crime");
			break;
			case 0:
				print("Hopefully you get one soon");
			break;
			default:
				print ("You must pop them like rabbits cuz of the tax return");
			break;
		}

		switch(degree){
			case "Doctorate":
				print("You are pretty smart");
			break;
			case "Master":
				print("You are way up there");
			break;
			case "Bachelor":
				print("You have made it");
			break;
			case "Associate":
				print("Keep going!");
			break;
			default:
				print ("Invalid Entry");
			break;
		}
		switch(sport){
			case "soccer":
				print("You like the most world wide played sport!");
			break;
			case "football":
				print("You live in America most likely");
			break;
			case "baseball":
				print("Welcome to the major leagues!");
			break;
			case "golf":
				print("That is not a sport, sir!");
			break;
			default:
				print ("You must not like the sports I like.");
			break;
		}

		switch(movieType){
			case "horror":
				print("that is my favorite type of movies!");
			break;
			case "thriller":
				print("I enjoyed this type almost as much as horror films.");
			break;
			case "action":
				print("It gets entertaining, but the plot is essential.");
			break;
			case "scifi":
				print("It must be really appealing and psychologically interesting for me to like it");
			break;
			default:
				print ("Most other type of movies I care little for");
			break;
		}

		switch(pets){
			case 3:
				print("You are an animal lover");
			break;
			case 2:
				print("You care about animals");
			break;
			case 1:
				print("One pet good enough for most families");
			break;
			case 0:
				print("PETA doesn't like you either");
			break;
			default:
				print ("Better donate some or PETA will be suspicious of you soon");
			break;
		}

		switch(anime){
			case "Death Note":
				print("That is a classic, top 3 most def!");
			break;
			case "Tokyo Goul":
				print("Very graphic and can get gory but the metaphors are deep too!");
			break;
			case "Another":
				print("Very creative and suspensful, it's like a 'Final Destination' with 'Sherlock Homes.' " );
			break;
			case "Elfen Lied":
				print("It can get bloody but it has a good plot");
			break;
			default:
				print ("You must not watch a lot of Animes.");
			break;
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
