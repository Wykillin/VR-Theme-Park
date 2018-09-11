using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnHomeScript : MonoBehaviour {

    public string MainScene = "Main";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        /*ContactPoint[] points = collision.contacts;
        Vector3 relpos = gameObject.transform.worldToLocalMatrix * points[0].point;
        float mag = Mathf.Sqrt(Mathf.Pow(relpos.x, 2) + Mathf.Pow(relpos.y, 2));
        Debug.Log(mag);*/
        //Debug.Log("Go home");
        if (collision.collider.gameObject.tag.Equals("projectile"))
        {
            SceneManager.LoadScene(MainScene);
        }
    }

}
