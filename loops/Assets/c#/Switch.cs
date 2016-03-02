using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour 
{
	public int intelligence = 5;

	void Greet()
	{
		switch (intelligence)
		{
		case 5:
			print ("Hello! are you a fan of Adele");
			break;
		case 4:
			print ("Hello! are you a fan of 21 Pilots");
			break;
		case 3:
			print ("do you like Paramore?");
			break;
		case 2:
			print ("asdf Justin Bieber!");
			break;
		case 1:
			print ("oNe dIrECtiOn...");
			break;
		default:
			print ("Listen to better music please");
			break;
		}
	}
}