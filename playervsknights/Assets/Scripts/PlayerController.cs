using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

	private float verticalSpeed = 20;
	private Rigidbody2D playerRigidBody;

	public Vector3 playerPos;
	public Transform player;

	public static bool playerExists = true;

	public GameManager theGameManager;
	static public int playerID = 0;
	public int playerScore;


	void Start () {
		playerRigidBody = GetComponent<Rigidbody2D> ();

	}


	void FixedUpdate () {
		Vector2 moveVector = new Vector2 (3f, CrossPlatformInputManager.GetAxis("Vertical")) * verticalSpeed;
		playerRigidBody.velocity = moveVector;	
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (playerID == 4) {
			if (other.gameObject.tag == "Enemy") {
				other.gameObject.SetActive (false);
				HUDScript.numberOfKills += 1;
			}
			if (other.gameObject.tag == "Obstacle") {
				if (HUDScript.numberOfLivesLeft > 0) {
					HUDScript.numberOfLivesLeft -= 1;
					gameObject.GetComponent<Animator> ().Play ("LifeLossAnimation");
				} else {
					playerExists = false;
					theGameManager.RestartGame ();
					playerScore = HUDScript.totalScore;
					dreamloLeaderBoard.AddNewHighScore (PlayerPrefs.GetString("username"), PlayerPrefs.GetInt ("highscore"));
					LevelGenerator.initialSpawn = true;
				}
			}
		} else {
			if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Obstacle") {
				if (HUDScript.numberOfLivesLeft > 0) {
					HUDScript.numberOfLivesLeft -= 1;
					gameObject.GetComponent<Animator> ().Play ("LifeLossAnimation");
				} else {
					playerExists = false;
					theGameManager.RestartGame ();
					playerScore = HUDScript.totalScore;
					dreamloLeaderBoard.AddNewHighScore (PlayerPrefs.GetString("username"), PlayerPrefs.GetInt ("highscore"));
					LevelGenerator.initialSpawn = true;
				}
			}
		}
	}
}
