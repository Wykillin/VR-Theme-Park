using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, 2f);
    }
}

/*
public class Baseball : MonoBehaviour
{
    private Rigidbody rb;

    void Awake()
    {
        rb.AddForce(transform.forward * Random.Range(1f, 2f), ForceMode.Impulse);
    }



    private void OnCollisionEnter(Collision collision)
    {

        //if (collision.gameObject.tag == "Bat") {

        rb.velocity = Vector3.zero;
        Debug.Log("Hello");

        //src.Play();

        //Physics.IgnoreCollision(collision.gameObject.GetComponent<CapsuleCollider>(), gameObject.GetComponent<SphereCollider>());



        float forceMultiplier = GetBatForce(collision.gameObject.GetComponent<Rigidbody>());

        Vector3 direction = (transform.position - collision.contacts[0].point).normalized;

        rb.AddForce(direction * forceMultiplier, ForceMode.Impulse);

        rb.useGravity = true;



        //t.enabled = true;

        Destroy(gameObject, 2f);

        //	}

    }
} */