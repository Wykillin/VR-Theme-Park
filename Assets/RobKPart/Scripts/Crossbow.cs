//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Crossbow : VRTK.VRTK_InteractableObject
{
	public GameObject bolt;
	public GameObject tip;
	public float boltSpeed = 1000f;
	public float boltLife = 5f;

	public override void StartUsing(VRTK.VRTK_InteractUse usingObject)
	{
		Debug.Log("test");
		base.StartUsing(usingObject);
		FireBolt();
	}

	protected void Start()
	{
		//bolt = transform.Find("Bullet").gameObject;
		//bolt.SetActive(false);
	}

	private void FireBolt()
	{
		GameObject boltClone = Instantiate(bolt, tip.transform.position, tip.transform.rotation) as GameObject;
		boltClone.SetActive(true);
		//Rigidbody rb = boltClone.GetComponent<Rigidbody>();
		Rigidbody rb = boltClone.GetComponentInChildren<Rigidbody>();
		rb.AddForce(-tip.transform.up * boltSpeed);
		//Destroy(boltClone, boltLife);
	}
}
