using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{

	public GameObject Target;
	private float timer = 0;


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (timer <= 0)
		{
			timer = Random.value + 1.0f;

			float throwForce = (4000 + (Random.value * 10));

			GameObject newTarget = Instantiate (Target, transform.position, transform.rotation) as GameObject;
			Rigidbody rb = newTarget.GetComponent<Rigidbody> ();
			rb.AddForce (transform.forward*throwForce);
			rb.AddTorque (Random.insideUnitSphere * 100);
			Destroy (newTarget, 5f);
		}
		timer -= Time.deltaTime;
	}
}
