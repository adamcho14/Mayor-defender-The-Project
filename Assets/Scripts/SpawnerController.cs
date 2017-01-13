using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

	public GameObject bandit;
	public Vector3 spawnValues;

	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool stop;

	// Use this for initialization
	void Start () {
		StartCoroutine (waitSpawner ());
	}
	
	// Update is called once per frame
	void Update () {
		
		spawnWait = Random.Range (spawnLeastWait, spawnMostWait);
		
	}

	IEnumerator waitSpawner() {
		yield return new WaitForSeconds (startWait);

		while (!stop) {

			float spawnX = Random.Range (-spawnValues.x, spawnValues.x);

			if (Mathf.Abs (spawnX) >= 3) {
				Vector3 spawnPosition = new Vector3 (spawnX, 
					                       spawnValues.y, 
					                       spawnValues.z);
				Quaternion rotationVector = Quaternion.Euler(0, 0, 0);
				/*if (spawnX < 0)
					rotationVector.y = -90;
				else
					rotationVector.y = 90;*/
				
				Instantiate (bandit, 
					spawnPosition + transform.TransformPoint (0, 0, 0), rotationVector);

			}

			yield return new WaitForSeconds (startWait);

		}
	}
}
