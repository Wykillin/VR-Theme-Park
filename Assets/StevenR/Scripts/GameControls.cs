using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControls : MonoBehaviour {
    public GameObject moleContainer;
    public float spawnDuration = 1.5f;
    public float spawnReducer = .1f;
    public float minSpawnTime = 0.5f;
    public float gameTimer = 45f;
    
    public GameObject cameraControl;
    public GameObject marker;
    public TextMesh TimerText;
    public MalletCollision player;
    
    public GameObject startButton;
    public float countdownTimer=5f;
    private MoleControls[] moles;
    private float spawnTimer = 0f;
    private float resetTime;
    public bool runGame = false;
    
	// Use this for initialization
	void Start () {
        resetTime = gameTimer;
        moles = moleContainer.GetComponentsInChildren<MoleControls>();
         moles[Random.Range(0, moles.Length)].Rise();
       // moles[5].Rise();
    }
	
	// Update is called once per frame
	void Update () {
        if (runGame == true)
        {
            if (countdownTimer >= 0f)
            {
             //  Debug.Log("The countdown timer is counting down");
                countdownTimer -= Time.deltaTime;
                TimerText.text = "Get Ready: " + Mathf.Floor(countdownTimer);
            }
            if (countdownTimer <= 0f)
            {
               // Debug.Log("The countdown is over");
                gameTimer -= Time.deltaTime;
                if (gameTimer > 0f)
                {
                    spawnTimer -= Time.deltaTime;
                    if (spawnTimer <= 0f)
                    {
                        moles[Random.Range(0, moles.Length)].Rise();
                        //moles[5].Rise();
                        spawnDuration -= spawnReducer;
                        if (spawnDuration < minSpawnTime)
                        {
                            spawnDuration = minSpawnTime;
                        }
                        spawnTimer = spawnDuration;
                    }
                    TimerText.text = "Whack-a-Mole\nTime:" + Mathf.Floor(gameTimer) +
                       "\nScore: " + player.score;
                    //Debug.Log("this is being called");
                }
                //}
                else
                {
                    TimerText.text = "Game Over! \nYour Score: " + player.score;
                    startButton.GetComponent<Button>().interactable = true;
                    runGame = false;
                    countdownTimer = 5f;

                }
            }
        }
	}

  public  void buttonPush()
    {
        
      cameraControl.transform.position = marker.transform.position;
        player.score = 0;
        gameTimer = resetTime;

        runGame = true;
       
        startButton.GetComponent<Button>().interactable = false;
    }
}
