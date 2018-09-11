using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleControls : MonoBehaviour {
    public float upHeight = 0.366f;
    public float downHeight = -.02f;
    public float speed = 1.5f;
    public float disapearDuration = 1.25f;
    public GameControls startGame;
    public bool isHit;
    private Vector3 newPosition;
    private float disapearTimer = 0f;
	// Use this for initialization
	void Start () {
		newPosition = new Vector3(transform.localPosition.x, upHeight, transform.localPosition.z);
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = Vector3.Lerp(transform.localPosition, newPosition, Time.deltaTime *speed );
        disapearTimer -= Time.deltaTime;
        if (disapearTimer <= 0f)
        {
            onHit();
        }
	}

    public void onHit()
    {
        newPosition = new Vector3(transform.localPosition.x, downHeight, transform.localPosition.z);
       // isHit = true;
       // Debug.Log(this.gameObject +"on hit is called");

    }

    public void Rise()
    {
        newPosition = new Vector3(transform.localPosition.x, upHeight, transform.localPosition.z);
        disapearTimer = disapearDuration;
        isHit = false;
    }
}
