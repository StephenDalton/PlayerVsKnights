using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour {
	public AudioClip heartSound;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			HUDScript.numberOfLivesLeft += 1;
			AudioSource.PlayClipAtPoint (heartSound, transform.position);
			gameObject.SetActive (false);
		}

	}
}
