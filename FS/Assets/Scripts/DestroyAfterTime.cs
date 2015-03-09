using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

	public float timeBeforeDestroy;
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, timeBeforeDestroy);
	}
}
