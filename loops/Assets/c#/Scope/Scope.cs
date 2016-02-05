﻿using UnityEngine;
using System.Collections;

public class Scope : MonoBehaviour
{
	public int alpha = 5;
	
	
	private int beta = 0;
	private int gamma = 5;
	
	
	private AnotherClass myOtherClass;
	
	
	void Start ()
	{
		alpha = 29;
		
		myOtherClass = new AnotherClass();
		myOtherClass.FruitMachine(alpha, myOtherClass.apples);
	}
	

	
	void Update ()
	{
		Debug.Log("Alpha is set to: " + alpha);
	}
}