using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHitted : MonoBehaviour {

    public GameObject target;
    public GameObject Horse;

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
   
        if (collision.gameObject.tag == "target")
        {
            Horse.GetComponent<Rigidbody>().AddForce(Vector3.right, ForceMode.Force);
            Debug.Log("Hit");
           

            
        }
    }
}
