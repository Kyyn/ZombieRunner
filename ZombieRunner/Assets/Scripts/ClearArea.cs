using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

    private float timeSinceLastTrigger = 0f;
    private int numberObjectsCollided = 0;
    private bool foundClearArea = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastTrigger += Time.deltaTime;

        if (numberObjectsCollided == 0 && timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea)
        {
            SendMessageUpwards("OnFindClearArea");
            Debug.Log("Clear Area Found");
            foundClearArea = true;
        }
	}


    void OnTriggerEnter(Collider other)
    {
        //Ignore collisions with player object.
        if (other.gameObject.name == "Player")
        {
            return;
        }
        numberObjectsCollided++;
        timeSinceLastTrigger = 0f;
    }

    void OnTriggerExit(Collider other)
    {
        //Ignore collisions with player object.
        if (other.gameObject.name == "Player")
        {
            return;
        }
        numberObjectsCollided--;
        timeSinceLastTrigger = 0f;
    }
}
