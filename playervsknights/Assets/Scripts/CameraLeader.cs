﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLeader : MonoBehaviour {

	public LevelGenerator theLeveLGenerator;
	private bool initialSpawn = true;

	public GameObject speedIncreaseWarning;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "WalkWay") {
			if (initialSpawn == true) {
				theLeveLGenerator.getUpdatedSpawnLocations ();
				initialSpawn = false;
			}
			if (LevelGenerator.walkWayLoadsIncrement >= 9) {
				LevelGenerator.walkWayLoadsIncrement = 0;
			}
			theLeveLGenerator.SpawnWalkWay ();
			theLeveLGenerator.SpawnOandE ();
			LevelGenerator.totalWalkWayLoads += 1;
			LevelGenerator.walkWayLoadsIncrement += 1;

			if (LevelGenerator.totalWalkWayLoads == 10) {
				SpawnMoveMent.verticalSpeed += 1;
				WalkWayManager.verticalSpeed += 1;
				BossController.verticalSpeed += 1;
				speedIncreaseWarning.gameObject.SetActive (true);
				StartCoroutine(RemoveSpeedWarning ());
			}
			if (LevelGenerator.totalWalkWayLoads == 19) {
				SpawnMoveMent.verticalSpeed += 1;
				WalkWayManager.verticalSpeed += 1;
				BossController.verticalSpeed += 1;
				speedIncreaseWarning.gameObject.SetActive (true);
				StartCoroutine(RemoveSpeedWarning ());
			}
		}
	}
	IEnumerator RemoveSpeedWarning () {
		yield return new WaitForSeconds (3);
		speedIncreaseWarning.gameObject.SetActive (false);
	}
}
    
