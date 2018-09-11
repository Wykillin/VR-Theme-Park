using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Keeper : MonoBehaviour {

    public static int score;

     static Text text;

	public GameObject animal1;
	public GameObject animal2;
	public GameObject animal3;
	public GameObject animal4;
	public GameObject animal5;
	public GameObject animal6;

	void Start(){
		animal1.SetActive (false);
		animal2.SetActive (false);
		animal3.SetActive (false);
		animal4.SetActive (false);
		animal5.SetActive (false);
		animal6.SetActive (false);
	}

    // Use this for initialization
     public void Awake () {
        text = GetComponent<Text>();
		score = 0;
    }
	
	// Update is called once per frame
     public void Update () {
        text.text = "Score: " + score;

		if(Score_Keeper.score == 1 && animal1.activeInHierarchy == false)
			animal1.SetActive (true);
		if(Score_Keeper.score == 2  && animal2.activeInHierarchy == false)
			animal2.SetActive (true);
		if(Score_Keeper.score == 4  && animal3.activeInHierarchy == false)
			animal3.SetActive (true);
		if(Score_Keeper.score == 6  && animal4.activeInHierarchy == false)
			animal4.SetActive (true);
		if(Score_Keeper.score == 8  && animal5.activeInHierarchy == false)
			animal5.SetActive (true);
		if(Score_Keeper.score == 9  && animal6.activeInHierarchy == false)
			animal6.SetActive (true);
	}
}
