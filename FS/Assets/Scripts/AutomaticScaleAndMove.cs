using UnityEngine;
using System.Collections;

public class AutomaticScaleAndMove : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	void FixedUpdate()
	{
		AlterPlayerScale (0.5f, 0.5f, 300.0f);
		AutoMove (5);
	}
	float scaleStep;
	public void AlterPlayerScale(float scaleValue, float initMagnitude, float scalingDuration)
	{
		//set scaling amount for scaling player    
		Vector3 newScale = new Vector3(initMagnitude+scaleValue, 
		                               initMagnitude+scaleValue, 
		                               initMagnitude+scaleValue);
		//scaling step
		 scaleStep += Time.deltaTime/scalingDuration;
		//alter player's scale
		transform.localScale = Vector3.Lerp(transform.localScale, 
		                                    newScale, 
		                                    scaleStep);
	}

	//Need method for move forward and back during time
	public void AutoMove(int speed)
	{
		transform.Translate (new Vector3 (0, -speed, 0) * Time.deltaTime);
	}

}
