﻿using UnityEngine;
using System.Collections;

public class SpinCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        t.localEulerAngles = t.localEulerAngles + new Vector3(0, Time.deltaTime * 60.0f, 0);
	}

    Transform t;
}
