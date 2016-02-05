using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour 

	{
		int cupsInTheSink = 4;
		
		void Start () 
		{
			while(cupsInTheSink > 0) 
			{
				Debug.Log ("i've washed a cup!");
				cupsInTheSink--;
		}
	}		
}