﻿using UnityEngine;
using System.Collections;

public class BoltMover : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = transform.up * 24;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
