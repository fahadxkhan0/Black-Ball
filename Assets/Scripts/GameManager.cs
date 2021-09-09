using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public bool gameOver;


	void Awake(){
		if(instance == null){
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		gameOver = false;
	}

	// Update is called once per frame
	void Update () {

	}

	public void StartGame(){
		UiManager.instance.GameStart ();
		EasyUiManager.instance.GameStart ();
		//UiManager.instance.textDownAnimation ();
		ScoreManager.instance.StartScore ();
		GameObject.Find ("EasyPlatformspawner").GetComponent<EasyPlatformspawner> ().StartSpawningPlatform ();
		GameObject.Find ("PlateformSpawner").GetComponent<PlateformSpawner> ().StartSpawningPlatform ();
	}

	public void GameOver(){
		UiManager.instance.Gameover ();
		EasyUiManager.instance.Gameover (); 
		ScoreManager.instance.StopScore ();
		gameOver = true;

	}

}
