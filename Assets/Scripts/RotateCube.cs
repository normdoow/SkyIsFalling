using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

	public float tumble;
	private Rigidbody rb;
	
	void Start() {			//called when this object is initialized
		rb = GetComponent<Rigidbody>();			//get the rigid body
		rb.angularVelocity = Random.insideUnitSphere * tumble; 		//add random angular velocity to the cube
	}
	
}
