using System.Collections; //provides access to .NET classes that define various collections of objects
using System.Collections.Generic; //provides access to .NET classes that define generic collections
using UnityEngine; //provides access to Unity classes

public class script1_wk6 : MonoBehaviour { //creates a public method for the particular script

	private Rigidbody rb; //sets the rigidbody to the variable rb and makes it only accessable within this block of script
    public float parameter2 = 10; //sets parameter2 to store floating-point values and is set at 10

	void Start () { // Initializes actions at start of the script
		print("Never name your script something this stupid, ever!"); //prints the text into the console
        rb = GetComponent<Rigidbody>(); //gets the rigidbody of the object
	}
	
	void Update () {// Updates script per frame
		rb.AddRelativeForce(Vector3.up * parameter2 * Input.GetAxis("Vertical")); //adds force to the rigidbody of the object relative to its coordinate system
        rb.AddTorque(Vector3.left * parameter2 * Input.GetAxis("Vertical")); //adds torque to the rigidbody of the object
	} 
}
