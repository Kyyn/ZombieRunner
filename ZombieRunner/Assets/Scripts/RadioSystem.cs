﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

    public AudioClip initialHeliCall;
    public AudioClip initialCallReplay;

    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMakeInitialHeliCall()
    {
        print(name + " OnMakeInitalHeliCall");
        audioSource.clip = initialHeliCall;
        audioSource.Play();

        Invoke("InitialReplay", initialHeliCall.length + 1f);
    }

    void InitialReplay()
    {
        audioSource.clip = initialCallReplay;
        audioSource.Play();
        BroadcastMessage("OnDispatchHelicopter");
    }
}
