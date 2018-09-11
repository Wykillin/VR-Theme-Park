using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour {

    public float maxDist = 100.0F, speed = 20.0F;

    float currDist = 0.0F, delayTime = 0.5F, currTime = 0.0F;
    Vector3 direction;
    float sign = 1.0F;

	// Use this for initialization
	void Start () {
        direction = transform.right;
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Mathf.Abs(currDist) >= maxDist)
        {
            currTime = 0.0F;
            sign *= -1.0F;
           // Debug.Log("Here");
        }*/
        float newDist = currDist + sign * Time.deltaTime * speed;
        if (Mathf.Abs(newDist) <= maxDist)
        {
            transform.position += sign * direction * Time.deltaTime * speed;
            currDist += sign * direction.magnitude * Time.deltaTime * speed;
            currTime += Time.deltaTime;
        }
        else
        {
            transform.position += sign * (maxDist - Mathf.Abs(currDist)) * direction;
            currDist += sign * (maxDist - Mathf.Abs(currDist));
            currTime += Time.deltaTime;
            sign *= -1.0F;
        }
        //Debug.Log(currDist);
	}
}
