using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour 
{
	public GameObject[] players;


	void Start () 

	{
	
		players = GameObject.FindGameObjectsWithTag("Player");
<<<<<<< HEAD
=======

		for(int i = 0; i < players.Length; i++)
>>>>>>> Arrays

		{
			Debug.Log("Player Number "+i+" is named "+players[i].name);
		}

	}

}
