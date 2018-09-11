using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counting_Script : MonoBehaviour {
	
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Transportable") {
			Score_Keeper.score += 1;
			Destroy (gameObject);
		}
	}
		

}
