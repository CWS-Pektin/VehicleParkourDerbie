﻿using UnityEngine;
using System.Collections;

public class CameraMotor : MonoBehaviour {

	private Transform lookAt;
	private Vector3 startOffset;

	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		lookAt = GameObject.FindGameObjectWithTag ("Player").transform;
		startOffset = transform.position - lookAt.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = lookAt.position + startOffset;
	}
}
