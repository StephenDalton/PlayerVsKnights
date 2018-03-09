using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {
	public Text scoreText;
	public Text livesText;
	public Text killsText;
	public Text coinsText;

	public static int totalScore;
	public static float timeScore;
	public static int numberOfKills;
	public static int numberOfLivesLeft;
	public static int coinsFoundThisGame;

	void Start () {
		if (PlayerController.playerID == 3) {
			numberOfLivesLeft = 3;
		}
	}

	void Update () {
		timeScore += Time.deltaTime;
		if (PlayerController.playerID == 1) {
			totalScore = (int)((timeScore * 10) + (numberOfKills * 70) + (coinsFoundThisGame * 10));
		} else {
			totalScore = (int)((timeScore * 10) + (numberOfKills * 50) + (coinsFoundThisGame * 10));
		}

		scoreText.text = "Score " + totalScore;
		livesText.text = "" + numberOfLivesLeft;
		coinsText.text = "" + PlayerPrefs.GetInt("coins");
		killsText.text = "" + numberOfKills;

	}

	public static void IncreaseScore(int amount) {
		timeScore += amount;
	}
		
}
