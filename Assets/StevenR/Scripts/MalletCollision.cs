using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalletCollision : MonoBehaviour {
    int i = 0;
    public int score = 0;
    public ManualVibrate leftCntrl;
    public ManualVibrate rightCntrl;
    public AudioSource hitSFX;

    private void Start()
    {
        //trackedObject= GetComponent<>
     
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("you hit a " + collision.gameObject.tag +i);
        if (collision.gameObject.tag == "MoleTag")
        {

            MoleControls mole = collision.gameObject.GetComponent<MoleControls>();
            mole.onHit();
            Debug.Log("mole is hit" + i + "before check" + mole.isHit);
            
            if (mole.isHit == false)
            {
               
                score++;
                hitSFX.Play();
                Debug.Log("the isHit is " + mole.isHit +i);
                leftCntrl.cntrlVibreate();
                rightCntrl.cntrlVibreate();
              
            }
            mole.isHit = true;
            i++;
        }

        
    }

    public void hitVibrate()
    {

    }
}
