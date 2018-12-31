using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;

	// Use this for initialization
	void Start () {
	
		Debug.Log("Welcome to Number Wizard");
		Debug.Log("Think in a Number, do not tell me yet!");
		Debug.Log("The min number you can think is " + min);
		Debug.Log("The max number you can think is " + max);
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			Debug.Log("You pressed Up!");
	
		}else if(Input.GetKeyDown(KeyCode.DownArrow)){		
			Debug.Log("You pressed Down!");
		
		}else if(Input.GetKeyDown(KeyCode.Return)){
			Debug.Log("You hit Enter!");

		}
	}
}
