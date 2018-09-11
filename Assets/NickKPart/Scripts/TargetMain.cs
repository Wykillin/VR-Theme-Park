using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMain : MonoBehaviour {

    public GameObject scoreboard;
    public float pointMultiplier = 1.0F;

    float timeElapsed = 0.0F, waitper = 0.5F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;
	}

    void addPoint(int points)
    {
        if (timeElapsed > waitper)
        {
            timeElapsed = 0.0F;
            scoreboard.SendMessage("addToScore", points * pointMultiplier);
        }
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        ContactPoint[] points = collision.contacts;
        Vector3 relpos = gameObject.transform.worldToLocalMatrix * points[0].point;
        float mag = Mathf.Sqrt(Mathf.Pow(relpos.x, 2) + Mathf.Pow(relpos.y, 2));
        Debug.Log(mag);
    }*/

}
