using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

	public float horizontalSpeed;
	private bool playGame;
	public int numberOfKills;
	public AudioClip killSound;


	void Start () {
		transform.Translate (new Vector3 (horizontalSpeed * Time.deltaTime, 0f, 0f));
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Enemy") {
			AudioSource.PlayClipAtPoint (killSound, transform.position);

			other.gameObject.SetActive (false);
			Destroy (gameObject);
			HUDScript.numberOfKills += 1;
		}
		if (other.gameObject.tag == "Obstacle") {
			Destroy (gameObject);
		}
	}
}