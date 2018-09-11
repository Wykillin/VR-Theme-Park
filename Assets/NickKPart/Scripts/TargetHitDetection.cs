using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHitDetection : MonoBehaviour {

    public GameObject target;
    public int points = 1;

    //float timesincelast = 0.0F, waitPer = 0.75F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //timesincelast += Time.deltaTime;
	}

    /*private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("triggered");
        if (timesincelast > waitPer)
        {
            timesincelast = 0.0F;
            target.SendMessage("addPoint", 1);
        }
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        /*ContactPoint[] points = collision.contacts;
        Vector3 relpos = gameObject.transform.worldToLocalMatrix * points[0].point;
        float mag = Mathf.Sqrt(Mathf.Pow(relpos.x, 2) + Mathf.Pow(relpos.y, 2));
        Debug.Log(mag);*/
        //Debug.Log("something happened");
        if (collision.collider.gameObject.tag.Equals("projectile"))
        {
            //Debug.Log("hit!");
            target.SendMessage("addPoint", points);
        }
    }

}
