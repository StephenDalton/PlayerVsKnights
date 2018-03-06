using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinChestController : MonoBehaviour {

	public AudioClip chestSound;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			HUDScript.coinsFoundThisGame += 10;
			PlayerPrefs.SetInt ("coins", PlayerPrefs.GetInt("coins") + 10);
			AudioSource.PlayClipAtPoint (chestSound, transform.position);
			gameObject.SetActive (false);
		}

	}

}
