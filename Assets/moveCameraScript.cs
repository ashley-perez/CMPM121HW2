using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// simple script that moves camera forward and backwards
public class moveCameraScript : MonoBehaviour
{
    // Vector3 forward = Camera.main.transform.forward;
    double counter = 0;

    void Update()
    {
        
        if (counter >= 0 && counter < 8) {
            transform.position += new Vector3(0,0,-4) * Time.deltaTime;
            counter += 0.01;
	    // hello
            // Debug.Log("in first if");
            // Debug.Log(counter);
        } 
        else if (counter >= 8 && counter <= 16) {
            transform.position += new Vector3(0,0,4) * Time.deltaTime;
            counter += 0.01;
	    // goodbye
            // Debug.Log("in else if");
        }
        else {
	    // bruh
            counter = 0;
            // Debug.Log("in the else statement that resets");
        }

    }
}
