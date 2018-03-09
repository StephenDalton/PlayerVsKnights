using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyController : MonoBehaviour {
	
	Transform playerPosition;
	//Transform enemyPosition;
	//private List<GameObject> Projectiles = new List<GameObject> ();
	//public GameObject fireBallPrefab;
	//private float speed = 12f;

	//GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

	void Start () {
		playerPosition = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update () {
		Vector3 newPos = new Vector3 (this.transform.position.x, playerPosition.position.y, 0);
		this.transform.position = Vector3.Lerp (transform.position, newPos, Time.deltaTime);
	}

	/*void OnTriggerEnter2D (Collider2D other) {
		Debug.Log ("!!");
		if (other.gameObject.tag == "Enemy") {
			enemyPosition = other.gameObject.transform;
			Shoot ();
			for (int i = 0; i < Projectiles.Count; i++) {
				GameObject fireBall = Projectiles[i];
				if (fireBall != null) {
					fireBall.transform.Translate(new Vector3(1, 0) * Time.deltaTime * 20);

					Vector3 newPos = new Vector3 (enemyPosition.position.x, enemyPosition.position.y, 0);
					fireBall.transform.position = Vector3.Lerp (transform.position, newPos, Time.deltaTime);
				}
			}
		}
	}*/

	/*void Shoot () {
		GameObject fireBall = (GameObject)Instantiate (fireBallPrefab, transform.position, Quaternion.identity);
		Projectiles.Add (fireBall); 
	}*/
}
