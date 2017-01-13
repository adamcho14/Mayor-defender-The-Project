using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour {
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	public void Fire(Vector3 target) {
		GameObject bullet = (GameObject)Instantiate (
			             bulletPrefab,
			             bulletSpawn.position,
			             bulletSpawn.rotation);

		bullet.GetComponent<Rigidbody> ().AddForce ((target-bullet.transform.position).normalized * 6);

		Destroy (bullet, 2.0f);
	}
}
