using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public string playGameLevel;
	public string settingsMenu;
	public string mainMenu;
	public string shopMenu;
	public string credits;
	public string characterSelection;
	public string highScores;

	void Awake () {
		Time.timeScale = 1f; 
		gameObject.GetComponent<Animator> ().Play ("IceBallMenuAnimation");
		if (PlayerPrefs.GetInt ("audio") == 0) {
			AudioListener.pause = true;
		}
		if (PlayerPrefs.GetInt ("audio") == 1) {
			AudioListener.pause = false;
		}
	}

	public void PlayGame () {
		LevelGenerator.initialSpawn = true;
		HUDScript.numberOfLivesLeft = 1;
		PlayerController.playerExists = true;
		LevelGenerator.walkWayLoadsIncrement = 0;
		LevelGenerator.totalWalkWayLoads = 0;
		SpawnMoveMent.verticalSpeed = 10;
		WalkWayManager.verticalSpeed = 10;
		BossController.verticalSpeed = 10;
		HUDScript.coinsFoundThisGame = 0;
		HUDScript.numberOfKills = 0;
		HUDScript.totalScore = 0;
		HUDScript.timeScore = 0;
		GameManager.isGameOver = false;
		if (GameManager.isFirstTimePlayer == true) {
			SceneManager.LoadScene (playGameLevel);
			Time.timeScale = 0f; 
		} else {
			SceneManager.LoadScene (playGameLevel);
			Time.timeScale = 1f;
		}
	}

	public void SettingsMenu () {
		SceneManager.LoadScene (settingsMenu);
	}

	public void GoMainMenu () {
		SceneManager.LoadScene (mainMenu);
	}

	public void ShopMenu () {
		SceneManager.LoadScene (shopMenu);
	}

	public void Credits () {
		SceneManager.LoadScene (credits);
	}
	public void ChooseCharacterMenu(){
		SceneManager.LoadScene (characterSelection);
	}

	public void QuitGame (){
		Application.Quit ();
	}

	public void HighScoresMenu(){
		SceneManager.LoadScene (highScores);
	}
		

}
