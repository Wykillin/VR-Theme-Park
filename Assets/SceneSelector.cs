using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSelector : MonoBehaviour
{
	public string MainScene = "Main";
	public string AlexScene = "AlexWPart/AlexWills";
	public string RobScene = "RobKPart/Rob's Scene";
	public string StevenScene = "StevenR/Steven Scene";
	public string AdamScene = "AdamWPart/Adam's Second Scene";
	public string NickScene = "NickKPart/Nick's Scene";

	public void loadMain()
	{
		SceneManager.LoadScene (MainScene);
	}

	public void loadAlex()
	{
		SceneManager.LoadScene (AlexScene);
	}

	public void loadRob()
	{
		SceneManager.LoadScene (RobScene);
	}

	public void loadSteven()
	{
		SceneManager.LoadScene (StevenScene);
	}

	public void loadAdam()
	{
		SceneManager.LoadScene (AdamScene);
	}

	public void loadNick()
	{
		SceneManager.LoadScene (NickScene);
	}
}
