using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditController : MonoBehaviour {

	private Rigidbody myRigidBody;

	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	private int counter;


	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.back* Time.deltaTime);

		counter++;
		if (Mathf.Abs(transform.position.z) < 9 && counter%36 == 0) {
			Fire ();
		}

		if (transform.position.z < 0) {
			Destroy (gameObject);
		}
	}

	void Fire() {
		var bullet = (GameObject)Instantiate (
			             bulletPrefab,
			             bulletSpawn.position,
			             bulletSpawn.rotation);
		bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 6;

		Destroy (bullet, 2.0f);
	}
}
