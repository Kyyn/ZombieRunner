using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daycycle : MonoBehaviour {

    [Tooltip ("Set a value for daycycle. Number of minutes per seconds that pass (try 60)")]
    public float minutesPerSecond = 60;

	
	// Update is called once per frame
	void Update () {
        float angleThisFrame = Time.deltaTime / 360  * minutesPerSecond;
        transform.Rotate (-angleThisFrame, 0, 0);
        //transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
		
	}
}
