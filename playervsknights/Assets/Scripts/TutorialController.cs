using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialController : MonoBehaviour {
	public GameObject scoreButton;
	public GameObject livesButton;
	public GameObject killsButton;
	public GameObject coinsButton;
	public GameObject shootingButton;
	public GameObject playTutorial;
	public GameObject movingTutorial;

	public Text scoreText;
	public Text livesText;
	public Text killsText;
	public Text coinsText;
	public Text shootingText;
	public Text movingText;

	public void Start() {
		if (PlayerPrefs.GetInt ("tutorialcompleted") == 1) {
			playTutorial.gameObject.SetActive (false);		
		} else {
			playTutorial.gameObject.SetActive (true);
		}
	}

	public void showScoreT () {
		scoreButton.gameObject.SetActive (false);
		scoreText.gameObject.SetActive (false);
		livesButton.gameObject.SetActive (true);
		livesText.gameObject.SetActive (true);

	}

	public void showLivesT () {
		livesButton.gameObject.SetActive (false);
		livesText.gameObject.SetActive (false);
		killsButton.gameObject.SetActive (true);
		killsText.gameObject.SetActive (true);
	}

	public void showKillsT () {
		killsButton.gameObject.SetActive (false);
		killsText.gameObject.SetActive (false);
		coinsButton.gameObject.SetActive (true);
		coinsText.gameObject.SetActive (true);

	}

	public void showCoinsT () {
		coinsButton.gameObject.SetActive (false);
		coinsText.gameObject.SetActive (false);
		shootingButton.gameObject.SetActive (true);
		shootingText.gameObject.SetActive (true);
	}

	public void shootTurorial () {
		shootingButton.gameObject.SetActive (false);
		shootingText.gameObject.SetActive (false);	
		movingTutorial.gameObject.SetActive (true);
		movingText.gameObject.SetActive (true);

	}

	public void playGame () {
		movingTutorial.gameObject.SetActive (false);
		movingText.gameObject.SetActive (false);
		playTutorial.gameObject.SetActive (false);
		Time.timeScale = 1f;
		PlayerPrefs.SetInt ("tutorialcompleted", 1);
	}
}
