using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour {

	private float speed = 3f;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Obstacle" || other.gameObject.tag == "coin" || other.gameObject.tag == "heart") {
			transform.Translate (new Vector3 (speed * Time.deltaTime, 0f, 0f));
		}
	}
}
