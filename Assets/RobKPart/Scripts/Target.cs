using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	public static ScoreKeeper sk;
	private bool hit = false;
		
	// Use this for initialization
	void Start ()
	{
		if (sk == null)
		{
			sk = GameObject.Find ("Score Board").GetComponent<ScoreKeeper>();
		}
	}
	
	void OnCollisionEnter(Collision coll)
	{
		if (coll.transform.tag == "Bolt" && !hit)
		{
			sk.AddToScore (10);
			hit = true;
		}
	}
}
