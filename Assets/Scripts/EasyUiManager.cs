using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasyUiManager : MonoBehaviour {

	public static EasyUiManager instance;

	public GameObject zigzagPanel;
	public GameObject gameOverPanel;
	public GameObject tapText;
	public Text score;
	public Text highScore1;
	public Text highScore2;

	void Awake(){
		if(instance == null){
			instance = this;
		}
	
	}

	// Use this for initialization
	void Start () {
		highScore1.text = "High Score: " + PlayerPrefs.GetInt ("highScore");
	}
	public void GameStart(){
		tapText.GetComponent<Animator> ().Play ("textDown");
		zigzagPanel.GetComponent<Animator> ().Play ("panelUp");
	}

	public void Gameover(){
		score.text = PlayerPrefs.GetInt ("score").ToString();
		highScore2.text = PlayerPrefs.GetInt ("highScore").ToString ();
		gameOverPanel.SetActive (true);
	}

	public void Reset(){
		SceneManager.LoadScene (0);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

