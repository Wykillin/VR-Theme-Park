using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToHome : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		GetComponent<SceneSelector> ().loadMain ();
	}
}
