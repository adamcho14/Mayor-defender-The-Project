using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicHealth : MonoBehaviour {

	public void TakeDamage() {
		
		Destroy (gameObject);
		//Debug.Log("Dead!");
	}
		
}
