﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start () 
	{
		StartGame();
	}
	void StartGame()
	{
		Debug.Log("Welcome to Number Wizard");
		Debug.Log("Think in a Number, do not tell me yet!!!!");
		Debug.Log("The min number you can think is " + min);
		Debug.Log("The max number you can think is " + max);
		Debug.Log("Push UP if it's higher, DOWN if lower, ENTER if I got the right number :)");
		Debug.Log("---------------------------------------");
		Debug.Log("Did you think in... "+ guess);
		max = max + 1;
	}
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			guess = (max+min) / 2;
			Debug.Log("Did you think in... "+ guess);
	
		}else if(Input.GetKeyDown(KeyCode.DownArrow)){		
			max = guess;
			guess = (max + min) / 2;
			Debug.Log("Did you think in... "+ guess);
		
		}else if(Input.GetKeyDown(KeyCode.Return)){
			Debug.Log("I got it!!! Your number is "+ guess);
		}
	}
}
