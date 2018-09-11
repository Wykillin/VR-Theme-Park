using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreboardMain : MonoBehaviour {

    int points = 0;

    public GameObject textfield;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void addToScore(int point)
    {
        points += point;
        textfield.GetComponent<TextMesh>().text = points.ToString();
    }

}
