using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;


public class Shoot : MonoBehaviour
{
    public float fireRate = .25f;
    public float range = 50;
    public ParticleSystem hitParticles;
    public Transform gunTransform;
    public LineRenderer lineRenderer;
    private SteamVR_TrackedController trackedController;
    private Valve.VR.InteractionSystem.Hand hand;
    public Transform gunEnd;
    private uint controllerIndex;

    public GameObject bulletPrefab;

    //private Vector2 touchpad;

    private SteamVR_Controller.Device controller {get {return SteamVR_Controller.Input( (int)hand.controller.index); } } 

    public AudioSource AudioSource { get; private set; }

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;


    private void Awake()
    {
        

    }
    // Use this for initialization
    void Start()
    {
        gunEnd = gameObject.transform;
        AudioSource = GetComponent<AudioSource>();
        trackedObj = gameObject.GetComponent<SteamVR_TrackedObject>();
        
        hand = GetComponent<Hand>();
        //controller = hand.controller;
        AudioSource = GetComponent<AudioSource>();
        lineRenderer = GetComponent<LineRenderer>();

        /*if (hand.controller == null)
        {
            Debug.Log("Controller not initilized");
            return;
        }*/

    }

  

    private void Fire()
    {
        // Create the Bullet from the Bullet Prefab
       
    }

    // Update is called once per frame
    void Update()
    {

        //device = SteamVR_Controller.Input((int)hand.controller.index);


       

        RaycastHit hit;


        if (Physics.Raycast(gunTransform.position, gunTransform.forward, out hit))
        {

            var bullet = (GameObject)Instantiate(
           bulletPrefab,
           gunEnd.position,
           gunEnd.rotation) as GameObject;

            // Add velocity to the bullet
            

            // Destroy the bullet after 2 seconds
            Destroy(bullet, 2.0f);

            if (hit.rigidbody == true)
            {
                //This is where the "horse" moves
            }

            lineRenderer.SetPosition(0, gunEnd.position);
            lineRenderer.SetPosition(1, hit.point);
            //Instantiate<ParticleSystem>(hitParticles, hit.point, Quaternion.identity);
            
            bullet.GetComponent<Rigidbody>().AddForce(gunEnd.transform.forward * 20f, ForceMode.VelocityChange);


        }


    }
}
