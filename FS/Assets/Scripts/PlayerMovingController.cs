using UnityEngine;
using System.Collections;


[System.Serializable]
public class Boundary
{
	public float xMin,xMax,zMin,zMax;
}
public class PlayerMovingController : MonoBehaviour {
	
	//for movement 
	public float speed;
	public float tilt;
	public Boundary boundary;
	private Rigidbody rb;


	//for one time rotation
	float rotAmount  = -360.0f;
	Vector3 destEuler = new Vector3(270,0,0);
	float speedRot = 14.0f;
	private Vector3 currEuler;


	// Use this for initialization
	void Start () {
		currEuler = destEuler;
		transform.eulerAngles = destEuler;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine (MakeOneTimeDeadlyNoose());
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//do movement
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * speed;
		//not leave scree
		rb.position = new Vector3 (Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax), 0.0f, Mathf.Clamp (rb.position.z, boundary.zMin, boundary.zMax));

		//rotate when rigth/left moving
		//rb.rotation = Quaternion.Euler (270.0f, 0.0f, rb.velocity.x * (tilt));
	}

	IEnumerator MakeOneTimeDeadlyNoose()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			destEuler.x += rotAmount;
		}
		currEuler =  Vector3.Lerp(currEuler, destEuler,Time.deltaTime/4 * speedRot);
		transform.eulerAngles = currEuler;
		yield return new WaitForSeconds(2.0f);
	}

}
