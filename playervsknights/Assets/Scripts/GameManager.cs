﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameOver theDeathScreen;
	public GameObject pauseGame;
	public PlayerController thePlayer;
	public static bool isGameOver = false;
	public static string playerUsername;
	public static bool nameChosen;
	public Toggle soundToggle;
	public Button fireButton;
	int totalEnemiesKilled;
	public int totalCoinsCollected;
	public string username;
	public int playerScore;

	public void Awake () {
		if (PlayerPrefs.GetInt ("audio") == 0) {
			soundToggle.isOn = false;
			AudioListener.pause = true;
		}
		if (PlayerPrefs.GetInt ("audio") == 1) {
			soundToggle.isOn = true;
			AudioListener.pause = false;
		}
		if (PlayerController.playerID == 3 || PlayerController.playerID == 4) {
			fireButton.gameObject.SetActive (false);
		} else {
			fireButton.gameObject.SetActive (true);
		}
		/*username = PlayerPrefs.GetString ("username");
		Debug.Log (username); */
	}

	public void Start () {
		username = PlayerPrefs.GetString ("username");
		Debug.Log (username);
	}

	public void RestartGame() {
		playerScore = HUDScript.totalScore;
		if (PlayerPrefs.GetInt ("highscore") < playerScore) {
			PlayerPrefs.SetInt ("highscore", playerScore);
			Debug.Log ("This works!!");
			dreamloLeaderBoard.AddNewHighScore (username, playerScore);
		}
		PlayerPrefs.SetInt ("tutorialcompleted", 1);
		Time.timeScale = 0;
		isGameOver = true;
		totalEnemiesKilled += HUDScript.numberOfKills;

		theDeathScreen.gameObject.SetActive (true);
		thePlayer.gameObject.SetActive (false);
	}

	//Forgive me for this function...
	public void Reset () {
		LevelGenerator.initialSpawn = true;
		LevelGenerator.totalWalkWayLoads = 0;
		LevelGenerator.walkWayLoadsIncrement = 0;
		SpawnMoveMent.verticalSpeed = 10;
		WalkWayManager.verticalSpeed = 10;
		BossController.verticalSpeed = 10;
		PlayerController.playerExists = true;
		HUDScript.numberOfKills = 0;
		HUDScript.numberOfLivesLeft = 1;
		HUDScript.timeScore = 0;
		HUDScript.coinsFoundThisGame = 0;
		isGameOver = false;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		thePlayer.gameObject.SetActive (true);
		Time.timeScale = 1f;
	}

	public void PauseGame () {
		Time.timeScale = 0;
		pauseGame.SetActive (true);
	}

	public void UnpauseGame () {
		pauseGame.SetActive (false);
		if (isGameOver == true) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
	}

	public void soundToggleChange (bool mute) {
		if (soundToggle.isOn == true) {
			AudioListener.pause = false;
			PlayerPrefs.SetInt ("audio", 1);
		}
		if (soundToggle.isOn == false) {
			AudioListener.pause = true;
			PlayerPrefs.SetInt ("audio", 0);
		}
	}
		
}

