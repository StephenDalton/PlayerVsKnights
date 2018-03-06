using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameOver theDeathScreen;
	public GameObject pauseGame;
	public PlayerController thePlayer;
	public static bool isGameOver = false;
	public static bool isFirstTimePlayer = true;
	public static string playerUsername;
	public static bool nameChosen;
	public Toggle soundToggle;

	//public static float highScore;
	int totalEnemiesKilled;
	public int totalCoinsCollected;

	public void Awake () {
		if (PlayerPrefs.GetInt ("audio") == 0) {
			soundToggle.isOn = false;
			AudioListener.pause = true;
		}
		if (PlayerPrefs.GetInt ("audio") == 1) {
			soundToggle.isOn = true;
			AudioListener.pause = false;
		}
	}

	public void RestartGame() {
		Time.timeScale = 0;
		isGameOver = true;
		if (PlayerPrefs.GetInt ("highscore") < HUDScript.totalScore) {
			PlayerPrefs.SetInt ("highscore", HUDScript.totalScore);
		}
		totalEnemiesKilled += HUDScript.numberOfKills;

		theDeathScreen.gameObject.SetActive (true);
		thePlayer.gameObject.SetActive (false);
	}

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
		if (isFirstTimePlayer == true) {
			Time.timeScale = 0f;
			isFirstTimePlayer = false;
		} else {
			Time.timeScale = 1f;
		}
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		thePlayer.gameObject.SetActive (true);
	}

	public void PauseGame () {
		Time.timeScale = 0;
		pauseGame.SetActive (true);
	}

	public void UnpauseGame () {
		pauseGame.SetActive (false);
		Time.timeScale = 1;
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

