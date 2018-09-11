using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;


public class TouchpadMovement : MonoBehaviour
{

    [SerializeField]
    private Transform rig;

    [SerializeField]
    private Valve.VR.InteractionSystem.Hand hand;

    private SteamVR_TrackedController trackedController;


    private uint controllerIndex;

    //private Vector2 touchpad;

    private SteamVR_Controller.Device controller; //{get {return SteamVR_Controller.Input( (int)hand.controller.index); } } 
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;
    private Vector2 axis = Vector2.zero;

    private void Awake()
    {

    }

    // Use this for initializati 'on
    void Start()
    {

        trackedObj = gameObject.GetComponent<SteamVR_TrackedObject>();
        Debug.Log((int)trackedObj.index);
        hand = gameObject.GetComponent<Hand>();
        controller = hand.controller;


       /* if (hand.controller == null)
        {
            Debug.Log("Controller not initilized");
            return;
        }*/

    }

    // Update is called once per frame
    void Update()
    {

        device = SteamVR_Controller.Input((int)hand.controller.index);



        if (device.GetTouch(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("Touchpad touched");

            axis = device.GetAxis(EVRButtonId.k_EButton_SteamVR_Touchpad);

            if (rig != null)
            {
                rig.position += ((transform.right * axis.x + transform.forward * axis.y) * 2) * Time.deltaTime;
                rig.position = new Vector3(rig.position.x, 0, rig.position.z);
            }
        }
    }
}
