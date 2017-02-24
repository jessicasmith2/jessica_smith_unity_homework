using System.Collections; //provides access to .NET classes that define various collections of objects
using System.Collections.Generic; //provides access to .NET classes that define generic collections
using UnityEngine; //provides access to Unity classes

public class testScript3 : MonoBehaviour { //creates a public method for the particular script

    public GameObject projectile; //sets the GameObject projectile as a public variable
    public float force = 20; //sets the floating value of the variable force to 20 and is public
    private GameObject clone; //sets the GameObject clone to private so that it will not be affected by further Fire1 commands

    void Update() // Updates script per frame
    {
        if (Input.GetButtonDown("Fire1")) //creates a conditional statement saying that if the Fire1 is activated the following actions are executed
        {
            clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject; //clones the projectile as a new game object and gets its position and rotation
            clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * force); //gets the cloned object's rigidbody and applies force for movement, in this case enough to make it appear to be thrown
        }
    }
}
