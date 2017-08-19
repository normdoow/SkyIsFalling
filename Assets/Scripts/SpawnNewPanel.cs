using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnNewPanel : MonoBehaviour {

	public Transform lastSpawn;
	public GameObject meanPanel;
	public GameObject deathBox;
	public float delay = 0f;
	public float maxPlatforms = 10f;
	public Text scoreText;

	private bool spawnedAPanel = false;
	//private Rigidbody rb;
	private int score = 0;
	
	void Awake() {
		//rb = GetComponent<Rigidbody> ();		//get the rigid body for this object
	}

	void OnCollisionEnter (Collision other) {		// if the player touches this panel
		if (!spawnedAPanel && other.gameObject.CompareTag("Player")) {
			Invoke ("SpawnPanel", delay);
			spawnedAPanel = true;
			print (int.Parse(scoreText.text.ToString()));
			score = int.Parse(scoreText.text.ToString());
			scoreText.text = "" + ++score;
		}
	}

	void SpawnPanel() {			//spawn another panel
		Vector3 position = new Vector3 (lastSpawn.position.x, lastSpawn.position.y - 5, lastSpawn.position.z);
		Instantiate(meanPanel, position, Quaternion.identity);
		lastSpawn.position = new Vector3(lastSpawn.position.x, lastSpawn.position.y, lastSpawn.position.z + 15);
		//move the spawn box
		deathBox.transform.position = new Vector3 (deathBox.transform.position.x, deathBox.transform.position.y, deathBox.transform.position.z + 15);
	}

	void Update() {		//update is called every frame
		if(meanPanel.transform.position.y < 0) {		//if the panel is below 0
			float translation = Time.deltaTime * 10;		//add an animation
			meanPanel.transform.Translate (0, translation, 0);
		}
	}
}
