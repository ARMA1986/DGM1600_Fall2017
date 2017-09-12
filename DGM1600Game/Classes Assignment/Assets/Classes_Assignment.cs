using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes_Assignment : MonoBehaviour {

	public class Demographics
	{
		public string sex;
		public int age;
		public string firstNameAndLastName;
		public int phoneNumber;

		public demographics(string sx, int ag, string firstNameAndLastName)
		{
			sex = sx;
			age = ag;
			firstNameAndLastName = name;
		}

		public demographics(string name, int num)
		{
			firstNameAndLastName = name ;
			phoneNumber = num;
		}

		// Constructor
		public Demographics ()
		{
			sex= "";
			age=0;
			firstNameAndLastName="";
			phoneNumber=0;
	
		}
	}
	// Creating instance
	public Demographics teacher = new Demographics (male, 32, JayNelson, 8013726593);
	public Demographics student = new Demographics (female, 22, AlyssaFry, 8013724267);
	
	// Use this for initialization
	void Start () {
		Debug.Log(teacher.sex);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
}
