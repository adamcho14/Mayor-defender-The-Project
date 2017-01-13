using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	private Rigidbody myRigidBody;

	public Transform target;

	void Start() {
		myRigidBody = GetComponent<Rigidbody> ();
	}


	void Update() {
		myRigidBody.transform.LookAt (target);
	}

	void OnCollisionEnter(Collision collision) {
		GameObject obj = collision.gameObject;
		if (obj.tag == "Player") {
			obj.transform.rotation = Quaternion.Euler (-1, 1, 90);
			Time.timeScale = 0;
		} else {
			var hit = collision.gameObject;
			var health = hit.GetComponent<PublicHealth> ();
			if (health != null) {
				health.TakeDamage ();
			}
		}
		Destroy (gameObject);
	}
}
