using System.Collections; //provides access to .NET classes that define various collections of objects
using System.Collections.Generic; //provides access to .NET classes that define generic collections
using UnityEngine; //provides access to Unity classes

public class TestScript2 : MonoBehaviour { //creates a public method for the particular script

    private Rigidbody rb;
    public float parameter1;
    private Renderer rend;
	
	void Start () { // Initializes actions at start of the script
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
	}
	
    void Update() // Updates script per frame
    {
        if (Input.GetButtonDown("Fire1")) //Creates a conditional statement saying that if the Fire1 is activated the following actions are executed
        {
            Color color = Random.ColorHSV(); //chooses a random color
            rend.material.SetColor("_Color", color); //applies color to object
            
        }
    }
	void OnCollisionEnter(Collision collision) //Activates on collision with another rigidbody
    {
        rb.AddForce(Vector3.up * parameter1); //adjusts force to the objectr's rigidbody upon collision
    }
}
