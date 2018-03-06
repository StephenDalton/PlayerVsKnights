using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	private Transform playertrans;
	private float speed = 15;
	private float dist = 7.5f;
	public static bool playerExists = true;
	public AudioClip coinSound;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			PlayerPrefs.SetInt ("coins", PlayerPrefs.GetInt("coins") + 1);
			HUDScript.coinsFoundThisGame += 1;
			AudioSource.PlayClipAtPoint (coinSound, transform.position);
			gameObject.SetActive (false);
		}
	}

	void Update () {
		if (PlayerController.playerID == 3 && GameManager.isGameOver == false) {
			playertrans = GameObject.Find ("Player").transform;
			if (PlayerController.playerExists) {
				if (Vector3.Distance (transform.position, playertrans.position) < dist) {
					transform.position = Vector3.MoveTowards (transform.position, playertrans.position, speed * Time.deltaTime);
				}
			}
		}
	}
}
