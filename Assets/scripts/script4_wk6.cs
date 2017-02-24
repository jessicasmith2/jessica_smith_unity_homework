using System.Collections; //provides access to .NET classes that define various collections of objects
using System.Collections.Generic; //provides access to .NET classes that define generic collections
using UnityEngine; //provides access to Unity classes

public class testScript4 : MonoBehaviour { //creates a public method for the particular script

    public float life = 100; //Sets a life counter as a floating number set currently to 100

	void Start () { // Initializes actions at start of the script
		//but there aren't any
	}
	
	void OnCollisionEnter(Collision collision) //Activates on collision with another rigidbody
    {
        print(collision.collider.name); //gets the name of the colliding object
        if(collision.collider.name != "Terrain") //sets a conditional statement for if it collides with terrain
        {
            life -= collision.collider.GetComponent<damageValue>().getDamage(); //retrieves and applies the amount of damage from the colliding object (50) to the cylinder
        }
        if(life < 0) //sets a conditional statement for if the object's life variable reaches zero or less
        {
            Destroy(gameObject); //destroys (deletes) the cylinder
        }
    }
}
