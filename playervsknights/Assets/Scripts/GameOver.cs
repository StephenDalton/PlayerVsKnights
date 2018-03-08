using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class GameOver : MonoBehaviour {

	public Text thisScore;
	public Text highScore;
	public Text coinsCollected;
	public Text knightsKilled;
	public Text distanceTraveled;

	public string settingsMenu;
	public string mainMenu;

	public void Update () {
		thisScore.text = "Score: " + HUDScript.totalScore;
		highScore.text = "Best Score: " + PlayerPrefs.GetInt("highscore");
		coinsCollected.text = "Coins Found: " + HUDScript.coinsFoundThisGame;
		knightsKilled.text = "Knights Killed: " + HUDScript.numberOfKills;
		distanceTraveled.text = "Distance: " + Math.Round((HUDScript.timeScore / 2), 1) + "m";
	}

	public void SettingsMenu () {
		SceneManager.LoadScene (settingsMenu);
	}

	public void GoMainMenu () {
		SceneManager.LoadScene (mainMenu);
		Time.timeScale = 1f;
	}

	//public void Retry () {
	//	FindObjectOfType<GameManager> ().Reset ();
	//}
}
