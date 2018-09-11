using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
	private Rigidbody rb;
	public float CustomGravity;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		rb.AddForce (Vector3.down * CustomGravity);
	}
}
