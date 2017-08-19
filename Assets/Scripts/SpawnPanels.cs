using UnityEngine;
using System.Collections;

public class SpawnPanels : MonoBehaviour {


	//not using this at the moment
	public int maxPlatforms = 10;
	public GameObject meanPanel;
	
	private Vector3 originPosition;
	
	void Start () {
		
		originPosition = transform.position;
		//Spawn ();
	}
	
	void Spawn() {
		for (int i = 0; i < maxPlatforms; i++) {
			float zPos = originPosition.z + (15 * i);
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 15);
			print (transform.position.z);
			Vector3 position = new Vector3(0, 0, zPos);
			Instantiate(meanPanel, position, Quaternion.identity);
		}
	}
}
