using UnityEngine;
using System.Collections;

public class EasyPlatformspawner : MonoBehaviour {
	Vector3 lastPos;
	
	float size;
	public GameObject plateform;
	public bool gameOver;
	public GameObject diamonds;

	// Use this for initialization
	void Start () {
		lastPos = plateform.transform.position;
		size = plateform.transform.localScale.x;
		for(int i=0; i<20; i++){
			SpawnPlateforms();
		}

	}

	public void StartSpawningPlatform(){
		InvokeRepeating ("SpawnPlateforms", 0.5f, 0.2f);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.gameOver == true) {
			CancelInvoke("SpawnPlateforms");
		}
	}

	void SpawnPlateforms(){
		int rand = Random.Range (0, 10);
		if (rand < 6) {
			SpawnX ();
		} else if (rand >= 6) {
			SpawnZ(); 
		}
	}

	void SpawnX(){
		Vector3 pos = lastPos;
		pos.x += size;
		lastPos = pos;
		Instantiate (plateform, pos, Quaternion.identity);

		int rand = Random.Range (0, 4);
		if (rand < 1) {
			Instantiate(diamonds,new Vector3(pos.x,pos.y + 1,pos.z), diamonds.transform.rotation);
		}

	}
	void SpawnZ(){
		Vector3 pos = lastPos;
		pos.z += size;
		lastPos = pos;
		Instantiate (plateform, pos, Quaternion.identity);

		int rand = Random.Range (0, 4);
		if (rand < 1) {
			Instantiate(diamonds,new Vector3(pos.x,pos.y + 1,pos.z), diamonds.transform.rotation);
		}


	}
}
