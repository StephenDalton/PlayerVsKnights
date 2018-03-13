using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinChestController : MonoBehaviour {

	public AudioClip chestSound;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			HUDScript.coinsFoundThisGame += 5;
			PlayerPrefs.SetInt ("coins", PlayerPrefs.GetInt("coins") + 5);
			AudioSource.PlayClipAtPoint (chestSound, transform.position);
			gameObject.SetActive (false);
		}

	}

}
