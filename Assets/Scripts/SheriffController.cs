using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheriffController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody myRigidbody;

	private Vector3 moveInput;
	private Vector3 moveVelocity;

	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	public GameObject squarePrefab;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		moveInput = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0f, Input.GetAxisRaw ("Vertical"));
		moveVelocity = moveInput * moveSpeed;

		if (/*Input.GetMouseButton(0)*/Input.GetKeyDown(KeyCode.Space)) {
			//GetComponent<FireBullet> ().Fire (Input.mousePosition);
			print("Mouse" + Input.mousePosition);
			Fire (Camera.main.ScreenToWorldPoint(Input.mousePosition));
		}

		/*if (Input.GetMouseButton(0)) {
			var square = (GameObject)Instantiate (squarePrefab, Quaternion.Euler(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
		}*/
	}

	void FixedUpdate () {
		myRigidbody.velocity = moveVelocity;
	}

	void Fire(Vector3 target) {
		var bullet = (GameObject)Instantiate (
			             bulletPrefab,
			             bulletSpawn.position,
			             bulletSpawn.rotation);
		target.Set (target.x, bulletSpawn.position.y, target.z);

		print ("Target" + target);

		print("Bullet" + (bullet.GetComponent<Rigidbody> ().velocity = (target - bulletSpawn.transform.position).normalized * 6));
		Destroy (bullet, 2.0f);
	}
}
