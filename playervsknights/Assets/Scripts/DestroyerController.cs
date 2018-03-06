using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerController : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Boss") {
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.tag == "Obstacle") {
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.tag == "WalkWay") {
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.tag == "Coin") {
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.tag == "Heart") {
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.tag == "Chest") {
			other.gameObject.SetActive (false);
		}
	}

}
