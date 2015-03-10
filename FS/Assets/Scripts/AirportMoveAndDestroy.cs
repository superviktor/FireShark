using UnityEngine;
using System.Collections;

public class AirportMoveAndDestroy : MonoBehaviour {
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float amountToMove = 7 * Time.deltaTime;
		transform.Translate (Vector3.back * amountToMove);
	}
}
