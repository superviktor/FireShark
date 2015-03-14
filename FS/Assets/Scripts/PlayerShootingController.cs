using UnityEngine;
using System.Collections;

public class PlayerShootingController : MonoBehaviour {

	private int shootingSystem;
	public GameObject boltSS0;
	//SS0

	public Transform leftShotSpawn0, rightShotSpawn0;

	//SS1
	public GameObject leftboltSS1,rightboltSS1;
	public Transform leftShotSpawn1, rightShotSpawn1,centerShotSpawn1;

	public float fireRate;
	private float nextFire;
	// Use this for initialization
	void Start () {
		shootingSystem = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		MakeShot (shootingSystem);
	}


	void MakeShot(int shootingSystem)
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		   {
			nextFire = Time.time +fireRate;
			switch(shootingSystem)
			{
				case 0:
				Instantiate(boltSS0, leftShotSpawn0.position, leftShotSpawn0.rotation);
				Instantiate(boltSS0, rightShotSpawn0.position, rightShotSpawn0.rotation);
				break;
				case 1:
				Instantiate(leftboltSS1, leftShotSpawn1.position, leftShotSpawn1.rotation);
				Instantiate(rightboltSS1, rightShotSpawn1.position, rightShotSpawn1.rotation);
				Instantiate(boltSS0, centerShotSpawn1.position, centerShotSpawn1.rotation);
				break;
			}
		}

	}
}

