using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour {
	int direction = 1;
	float top = 3f;
	float bottom = -4f;
	float speed = 5f;

	public static float verticalSpeed = 8;
	private Rigidbody2D rb;

	void Awake() {
		rb = GetComponent<Rigidbody2D> ();
		if (LevelGenerator.totalWalkWayLoads == 10) {
			verticalSpeed += 1;
		}
	}

	void Update () {
		if (transform.position.y >= top) {
			direction = -1;
		}
		if (transform.position.y <= bottom) {
			direction = 1;
		}
		transform.Translate (0, speed * direction * Time.deltaTime, 0);
		rb.velocity = new Vector2 (verticalSpeed * -1, 0);
	}
}
