using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	string message = "Help Me!?!";
	
	// Use this for initialization
	void Start () {
		print("What do you need?");
	}
	
	// Update is called once per frame
	void Update () {
		print (message);
	}
}

