using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour {

	// Functions with parameters. Parameters are the range or expected input that will be accepted
	// for an specific method. The type of parameter expeced should be compatible or the same with 
	// the type of function we have declared. For example for an "int something (int a,int b){...}"
	// Where int a and int b are the expected values, the parameters have been set to making it
	// an int type. 

	// Functions with return. Return within a function makes the result of a function usable. If we
	// have the function use certain variables to create a new result, this result must be saved or
	// returned to a given varaible. We use the result command to save the result to this new variable.
	// This return type variable is only used locally so in order to use it outside of its class, we 
	// must first call the function and then we can print the variable out to the console.

	// Scope and Access Modifiers. The Scope is what is inside of the brackets of a class. It involves
	// local items pertaining to that class and that class only. Access modifiers are when we set a 
	// variable to either public or private. When we want to modify and see variables we generally use
	// public variables, when we don't want the variable to be seen and just want it to make other
	// parts of our script work, we usually set those variables to private.
	
	public void doStuff(){
		print("I'm doing StufFFF . . .");
	}
	public int AddNumbers(int num1, int num2){
		int sum = num1 + num2;
		return sum;
	}
	public void names(){
		print("Enter your name here please: ");
	}
	public string myName(string nom1, string nom2){
		string nomes= nom1 + nom2;
		return nomes;
	}

	public string name1="";
	public string name2="";
	private string names3 (string name1, string name2){
		string namess = name1 + " "+ name2;
		return namess;
	}

	public void chooseCharacter(){
		print("Choose a character out of the list:  (1)Boo Boo (2)Tracker (3)Olaf  \nChoose a number for the character");
	}
	public int character;
	
	public void selectedCharacter(){
		if (character == 1)
		{
			print("Boo Boo is a wise choice");
		}
		else if (character == 2){
			print("Tracker takes skills, good luck!");
		}
		else if (character == 3){
			print("Choosing Olaf is either GG or you're gonna suck badly");
		}
		else
		{
			print("You have entered an incorrect input.");
		}
	
	}



	
	// Use this for initialization
	void Start () {
		
		doStuff();
		int sum = AddNumbers(5,11);
		print(sum);
		names();
		string nomes = myName("Jose"," Luis");
		print(nomes);
		string namess = names3(name1,name2);
		print(namess);
		chooseCharacter();
		selectedCharacter();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
