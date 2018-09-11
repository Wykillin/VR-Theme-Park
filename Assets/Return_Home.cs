using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return_Home : MonoBehaviour {

	public string MainScene = "Main";

	
	void OnTriggerEnter(Collider other){
		SceneManager.LoadScene (MainScene);
	}
}
