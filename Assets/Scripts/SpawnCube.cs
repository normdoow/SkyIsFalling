using UnityEngine;
using System.Collections;

public class SpawnCube : MonoBehaviour {

	public Transform[] cubeSpawns;
	public GameObject cube;
	public float delay = 1f;

	//private Rigidbody rb;
	
	void Awake() {			//when the class is initialized
		//rb = GetComponent<Rigidbody>();
	}

	void OnCollisionEnter (Collision other) {		//
		if (other.gameObject.CompareTag("Player")) {		//if the Player touches the panel object
			Invoke ("Spawn", delay);						//spawn the cubes after 1 second
		}
	}
	
	void Spawn() {								//spawns the cubes
		for (int i = 0; i < cubeSpawns.Length; i++) {		//go through all the spawn points
			int randomNum = Random.Range (0, 2);		//gives a 50% chance of spawning a cube here
			if (randomNum > 0) {
				Instantiate (cube, cubeSpawns[i].position, Quaternion.identity);		//spawn the cube
			}
		}
	}
}
