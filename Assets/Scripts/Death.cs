using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Death : MonoBehaviour {

	public Text scoreText;

	void OnTriggerExit(Collider other) {		//when something exits the box
		if (other.gameObject.tag == "Player") {		//if the object is the player
			print ("You died");
			Application.LoadLevel(Application.loadedLevel);		//restart the game
			scoreText.text = "0";
		} else {									//if the object is something else
			Destroy (other.gameObject);				//destory the object
		}
	}
}
