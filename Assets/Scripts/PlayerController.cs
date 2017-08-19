using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//declare variables
	public float speed;
	public float jumpForce;
	
	private Rigidbody rb;
	private bool canJump = true;
	
	void Start () {		//called when this class is initialized
		rb = GetComponent<Rigidbody>();		//gets the rigid body for this object
	}
	
	void FixedUpdate () {		//fixed update called incramentally to do physics stuff
		float moveHorizontal = Input.GetAxis ("Horizontal");		//gets the value from pushing down arrow keys
		float moveVertical = Input.GetAxis ("Vertical");
		if (rb.velocity.x < 10 && rb.velocity.z < 10) {				//if were not going too fast
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			rb.AddForce (movement * speed);			//add the force ot the player
		}
		if (canJump && Input.GetKeyDown ("space")) {		//if you hit space bar can jump
			print ("space bar pressed!");
			Vector3 jump = new Vector3(0, jumpForce, 0);
			rb.AddForce(jump);								//add the force
		}
	}

	void OnCollisionStay (Collision collision){				//check if you are grounded
		canJump = true;
	}
	void OnCollisionExit(Collision collision){				//you are in the air			
		canJump = false;
	}
}
