using System.Collections; //provides access to .NET classes that define various collections of objects
using System.Collections.Generic; //provides access to .NET classes that define generic collections
using UnityEngine; //provides access to Unity classes

public class testScript5 : MonoBehaviour { //creates a public method for the particular script
   
    public float parameter1 = 0.1f; //creates the variable parameter1 as a public floating value, currently at 0.1
    public float parameter2 = 0.1f; //creates the variable parameter2 as a public floating value, currently at 0.1
    public float parameter3 = 10; //creates the variable parameter3 as a public floating value, currently at 10
    public float parameter4 = -10; //creates the variable parameter4 as a public floating value, currently at -10
    private bool parameter5 = true; //creates the variable parameter5 as a private boolean value, currently true
	
	void Start () { // Initializes actions at start of the script
		//but there aren't any
	}
	
	void Update () { // Updates script per frame
        if(parameter1 > parameter3) //sets conditional statement that executes if parameter1 is greater than parameter3
        { 
            parameter5 = false; //sets parameter5 to false
        }
        if (parameter5) //sets conditional statement that executes if parameter5 is true
        {
            parameter1 += parameter2; //increases parameter1 by adding parameter1 with parameter2
            RenderSettings.skybox.SetFloat("_Exposure", parameter1); //sets the exposure of the skybox to the new value given to parameter1
        } else //executes if parameter5 is false
        {
            parameter1 -= parameter2; //decreases parameter1 by subtracting parameter1 from parameter2
            RenderSettings.skybox.SetFloat("_Exposure", parameter1); //sets the exposure of the skybox to the new value given to parameter1
        }
        if(parameter1 < parameter4) //sets conditional that executes if parameter1 is less than parameter4
        {
            parameter5 = true; //sets parameter5 to true
        }

    }
}
