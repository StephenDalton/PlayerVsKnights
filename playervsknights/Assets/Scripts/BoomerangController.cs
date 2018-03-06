using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangController : MonoBehaviour {

	public float speed = 15;
	bool returning;

	public AudioClip killSound;

	private Transform playertrans;
	float boomerangTimer;

	void OnEnable (){
		playertrans = GameObject.Find ("Player").transform;
		boomerangTimer = 0.0f;
	}

	void Update () {
		boomerangTimer += Time.deltaTime;

		if (boomerangTimer >= .3f) {
			returning = true;
		}
		if (returning == false) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		} else {
			transform.right = playertrans.position - transform.position;
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			Destroy (gameObject);
		}
		if (other.tag == "Enemy" || other.tag == "Boss") {
			AudioSource.PlayClipAtPoint (killSound, transform.position);
			other.gameObject.SetActive (false);
			returning = true;
			HUDScript.numberOfKills += 1;
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "Player") {
			Destroy (gameObject);
		}
	}
}
