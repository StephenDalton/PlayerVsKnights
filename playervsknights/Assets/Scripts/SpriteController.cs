using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour {

	public Sprite[] PlayerSprites;
	private int playerID = PlayerController.playerID;

	void Start () {
		if (playerID == 0) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = PlayerSprites [0];
		}
		if (playerID == 1) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = PlayerSprites [1];
		}
		if (playerID == 2) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = PlayerSprites [2];
		}
		if (playerID == 3) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = PlayerSprites [3];
		}
		if (playerID == 4) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = PlayerSprites [4];
		}
		if (playerID == 5) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = PlayerSprites [5];
		}
		if (playerID == 6) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = PlayerSprites [6];		}
	}
}
