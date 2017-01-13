using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayorController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody myRigidbody;

	private Vector3 moveInput;
	private Vector3 moveVelocity;


	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
