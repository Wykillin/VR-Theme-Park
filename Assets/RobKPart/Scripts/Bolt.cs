using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
	Rigidbody rb;

	bool stuck = false;

	void OnCollisionEnter(Collision coll)
	{

		if (!stuck)
		{
			stuck = true;
			rb.isKinematic = true;
			transform.rotation.SetLookRotation (coll.contacts [0].normal);
			transform.SetParent (coll.transform);
		}
		//transform.parent = coll.transform;



		//Debug.Log (coll.contacts[0].normal);
	}




	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
