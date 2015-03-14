using UnityEngine;
using System.Collections;

public class LeftPlayerBoltMover : MonoBehaviour {

	private Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3(-10,0,28);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
