using UnityEngine;
using System.Collections;

public class dowhile : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		bool shouldcontinue = false;

		do {
			print ("Hello World");

		} while(shouldcontinue == true);
	
	}
}
