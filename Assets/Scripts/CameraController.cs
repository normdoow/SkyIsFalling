using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;			//referece to the Player
	private Vector3 offset;				//vector to hold the offset
	
	void Start () {						//called when class intantsiates
		offset = transform.position - player.transform.position;
	}
	
	void LateUpdate () {				//update the camera according to the players position
		transform.position = player.transform.position + offset;
	}
}
