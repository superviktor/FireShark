using UnityEngine;
using System.Collections;

public class BackgroundMoving : MonoBehaviour {
	
	public float speed;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float amountToMove = speed * Time.deltaTime;
		transform.Translate (Vector3.down * amountToMove,Space.Self);
		if (transform.position.z < -47.0f) 
		{
			transform.position = new Vector3(transform.position.x , transform.position.y, 88.3f);
		}
		
	}
}
