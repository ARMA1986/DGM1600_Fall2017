using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {
	// stating public variables to be used as input on unity's inspector
	public float valueOne;

	public float valueTwo;

	public float valueThree;

	public float valueFour;

	// stating private variables to be used with the operators
	private float result;

	private float resultTwo;

	// Use this for initialization
	void Start () {
		DoMath();
		
	}
	
	// creating the DoMath function
	void DoMath () {

		// Stating what result is by using math operators in this example
		// and using the valueOne and valueTwo variables
		result = valueOne + valueTwo;
		// Print the result per desired operation
		print(valueOne + " + " + valueTwo + " = " + result );
		result = valueOne - valueTwo;
		print(valueOne + " - " + valueTwo + " = " + result );
		result = valueOne * valueTwo;
		print(valueOne + " * " + valueTwo + " = " + result );
		result = valueOne / valueTwo;
		print(valueOne + " / " + valueTwo + " = " + result );

		// Stating what resultTwo is by using math operators in this example
		// and using the valueThree and valueFour variables
		resultTwo = valueThree + valueFour;
		// print the value of the desired operation
		print(valueThree + " + " + valueFour + " = " + resultTwo );
		resultTwo = valueThree - valueFour;
		print(valueThree + " - " + valueFour + " = " + resultTwo );
		resultTwo = valueThree * valueFour;
		print(valueThree + " * " + valueFour + " = " + resultTwo );
		resultTwo = valueThree / valueFour;
		print(valueThree + " / " + valueFour + " = " + resultTwo );
	}
	// Update is called once per frame
	void Update () {
		
	}
}
