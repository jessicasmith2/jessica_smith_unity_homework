using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
	public Rigidbody rb;

    void OnCollisionEnter(Collision collision)
    {
    	print("Pow");
    }
}