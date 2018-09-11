using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
	public float Score{ get; set; }
	public Text scoreText;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		scoreText.text = Score.ToString();
	}

	public void AddToScore(float amount)
	{
		Score += amount;
	}
}
