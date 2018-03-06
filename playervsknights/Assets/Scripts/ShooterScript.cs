using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour {

	private float projectileVelocity;
	private List<GameObject> Projectiles = new List<GameObject> ();
	public GameObject projectilePrefab;
	public GameObject boomerangPrefab;
	public GameObject arrowPrefab;
	public GameObject bombPrefab;

	public float bombShootTimer = 5f;
	private float timer;

	private int playerID;

	public PoolManager projectilePool;

	void Start () {
		projectileVelocity = 15;
		playerID = PlayerController.playerID;
	}

	void Update () {
		if (Input.GetButtonDown ("Shoot")) {
			Shoot ();
		}

		for (int i = 0; i < Projectiles.Count; i++) {
			GameObject arrow = Projectiles[i];
			if (arrow != null) {
				arrow.transform.Translate(new Vector3(1, 0) * Time.deltaTime * projectileVelocity);

				Vector3 arrowPosition = Camera.main.WorldToScreenPoint (arrow.transform.position);		//These bits deletes the arrow instance once it leaves the screen
				if (arrowPosition.x > Screen.width) {
					Destroy (arrow);
				}
			}
		}
	}

	public void Shoot () {
		if (playerID == 0) {
			GameObject iceBall = (GameObject)Instantiate (projectilePrefab, transform.position, Quaternion.identity);
			Projectiles.Add (iceBall);
		}
		if (playerID == 2) {
			GameObject boomerrang = (GameObject)Instantiate (boomerangPrefab, transform.position, Quaternion.identity);
			Projectiles.Add (boomerrang);

		}
		if (playerID == 1) {
			GameObject arrow = (GameObject)Instantiate (arrowPrefab, transform.position, Quaternion.identity);
			Projectiles.Add (arrow);
		}
		if (playerID == 5) {
			if (Time.time >= timer) {
				GameObject bomb = (GameObject)Instantiate (bombPrefab, transform.position, Quaternion.identity);
				Projectiles.Add (bomb);
				timer = Time.time + bombShootTimer;
			}
		}
	}
}
