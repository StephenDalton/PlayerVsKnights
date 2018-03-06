using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour {

	private float speed = 10;
	private float bombTimer;

	public AudioClip killSound;

	private BoxCollider2D bCollider;


	void Update () {
		transform.Translate (new Vector3 (speed * Time.deltaTime, .3f, 0f));
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Enemy") {
			HUDScript.numberOfKills += 1;
			other.gameObject.SetActive (false);
			Destroy (gameObject, .7f);
			AudioSource.PlayClipAtPoint (killSound, transform.position);
		}
		if (other.gameObject.tag == "Obstacle") {
			other.gameObject.SetActive (false);
			Destroy (gameObject, .7f);
		}
		if (other.gameObject.tag == "Detonator") {
			Destroy (gameObject);
		}
	}
}