using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManualVibrate : MonoBehaviour {
    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device device;
	// Use this for initialization
	void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cntrlVibreate()
    {
        device = SteamVR_Controller.Input((int)trackedObject.index);
        device.TriggerHapticPulse(2000);
    }
}
