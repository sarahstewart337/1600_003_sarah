using UnityEngine;
using System.Collections;

public class ifstatements : MonoBehaviour 
{
	


		public float refrigeratorTemperature = 85.0f;
		public float hotlimitTemperature = 70.0f;
		public float coldlimitTemperature = 40.0f;

	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
				TemperatureTest();
			refrigeratorTemperature -=Time.deltaTime * 5f;

	}

		void TemperatureTest()
		{
			// If the fridge is temp is too hot
			if (refrigeratorTemperature > hotlimitTemperature) 
			
			{
				//then do this
				print ("Refrigerator is too hot.");
			}

			
			// if it is not, and the temp is less than the coldest temperature...
				else if(refrigeratorTemperature < coldlimitTemperature)
		

			{
				//do this...
				print("Fefrigerator is too cold.");
			
			}
			else
			{
				//... do this
				print ("refrigerator is just right.");
			}

		}
}
