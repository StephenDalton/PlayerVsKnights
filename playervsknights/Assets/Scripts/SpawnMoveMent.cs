using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoveMent : MonoBehaviour {

	public static float verticalSpeed = 10;
	private Rigidbody2D rb;

	void Awake () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void LateUpdate() {
		rb.velocity = new Vector2 (verticalSpeed * -1, 0);
	}


}
