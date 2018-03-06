using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;
	//Obstacles and Enemies:
	public GameObject[] blueGroundSpawn;
	public GameObject[] greenGroundSpawn;
	public GameObject[] redGroundSpawn;
	public GameObject[] redBeardGroundSpawn;
	public int firstBlueNumberOfObstacles;
	public int blueNumberOfObstacles;
	public int greenNumberOfObstacles;
	public int redNumberOfObstacles;
	public int numberOfBosses;
	public int numberOfHearts;
	public int numberOfChests;
	//Background/Path Generate:
	public GameObject walkWay, walkWay2, walkWay3;
	private float currentGameWidth;
	private int numberOfSpawnPositions = 4;
	public static int walkWayLoadsIncrement;
	public static int totalWalkWayLoads = 0;
	public static bool initialSpawn = true;


	public static bool timeToSpawn = false;

	public PoolManager theObjectPool;


	void Start() {
		//SpawnOandE ();
		currentGameWidth = -12f;
		SpawnWalkWay ();
	}
		
	public void getUpdatedSpawnLocations () {
		currentGameWidth += 31f;
		xMin += 10f;
		xMax += 30f;
	}

	public void SpawnWalkWay() {
		transform.position = new Vector3 (currentGameWidth, 2f, 0f);
		if (walkWayLoadsIncrement <= 4) {
			GameObject newPlatform = theObjectPool.GetBlueWalkWay();
			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive (true);
		}
		if (walkWayLoadsIncrement > 4 && walkWayLoadsIncrement < 7) {
			GameObject newPlatform = theObjectPool.GetGreenWalkWay();
			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive (true);
		} 
		if (walkWayLoadsIncrement >= 7) {
			GameObject newPlatform = theObjectPool.GetRedWalkWay();
			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive (true);
		}
	}

	//----------------------------------------------------------------------------------

	public void SpawnOandE() {
		//Blue level loads:////////////////////////
		float spawnPos = -4.2f;
		if (PlayerController.playerID == 4 && walkWayLoadsIncrement <= 4) {
			for (int i = 0; i < numberOfSpawnPositions; i++) {
				for (int x = 0; x < blueNumberOfObstacles; x++) {
					Vector2 pos = new Vector2 (Random.Range (xMin, xMax), spawnPos);
					GameObject goodsPrefab = redBeardGroundSpawn [Random.Range (0, redBeardGroundSpawn.Length)];
					GameObject newSpawn = theObjectPool.GetCoin();

					if (goodsPrefab == redBeardGroundSpawn [0]) {
						newSpawn = theObjectPool.GetWoodenBox ();
					} else if (goodsPrefab == redBeardGroundSpawn [1]) {
						newSpawn = theObjectPool.GetWoodenBox ();
					} else if (goodsPrefab == redBeardGroundSpawn [2]) {
						newSpawn = theObjectPool.GetKnight1 ();
					} else if (goodsPrefab == redBeardGroundSpawn [3]) {
						newSpawn = theObjectPool.GetCoin ();
					}
					newSpawn.transform.position = pos;
					newSpawn.transform.rotation = transform.rotation;
					newSpawn.SetActive (true);

				}
				spawnPos += 2.4f;			
			}
		}
		if (PlayerController.playerID != 4 && walkWayLoadsIncrement <= 4 && initialSpawn == false) {
			for (int i = 0; i < numberOfSpawnPositions; i++) {
				for (int x = 0; x < blueNumberOfObstacles; x++) {
					Vector2 pos = new Vector2 (Random.Range (xMin, xMax), spawnPos);
					GameObject goodsPrefab = blueGroundSpawn [Random.Range (0, blueGroundSpawn.Length)];
					GameObject newSpawn = theObjectPool.GetCoin();

					if (goodsPrefab == blueGroundSpawn [0]) {
						newSpawn = theObjectPool.GetWoodenBox ();
					} else if (goodsPrefab == blueGroundSpawn [1]) {
						newSpawn = theObjectPool.GetKnight1 ();
					} else if (goodsPrefab == blueGroundSpawn [2]) {
						newSpawn = theObjectPool.GetKnight2 ();
					} else if (goodsPrefab == blueGroundSpawn [3]) {
						newSpawn = theObjectPool.GetCoin ();
					}
					newSpawn.transform.position = pos;
					newSpawn.transform.rotation = transform.rotation;
					newSpawn.SetActive (true);

						
				}
				spawnPos += 2.4f;			
			}
		}
		if (PlayerController.playerID != 4 && walkWayLoadsIncrement <= 4 && initialSpawn == true) {
			for (int i = 0; i < numberOfSpawnPositions; i++) {
				for (int x = 0; x < firstBlueNumberOfObstacles; x++) {
					Vector2 pos = new Vector2 (Random.Range (xMin, xMax), spawnPos);
					GameObject goodsPrefab = blueGroundSpawn [Random.Range (0, blueGroundSpawn.Length)];
					GameObject newSpawn = theObjectPool.GetCoin();

					if (goodsPrefab == blueGroundSpawn [0]) {
						newSpawn = theObjectPool.GetWoodenBox ();
					} else if (goodsPrefab == blueGroundSpawn [1]) {
						newSpawn = theObjectPool.GetKnight1 ();
					} else if (goodsPrefab == blueGroundSpawn [2]) {
						newSpawn = theObjectPool.GetKnight2 ();
					} else if (goodsPrefab == blueGroundSpawn [3]) {
						newSpawn = theObjectPool.GetCoin ();
					}
					newSpawn.transform.position = pos;
					newSpawn.transform.rotation = transform.rotation;
					newSpawn.SetActive (true);

				}
				spawnPos += 2.4f;			
			}
			initialSpawn = false;
		}
		//Green level loads:///////////////////////-----------------------------------------------------------
		if (walkWayLoadsIncrement > 4 && walkWayLoadsIncrement < 7) {
			for (int i = 0; i < numberOfSpawnPositions; i++) {
				for (int x = 0; x < greenNumberOfObstacles; x++) {
					Vector2 pos = new Vector2 (Random.Range (xMin, xMax), spawnPos);
					GameObject goodsPrefab = greenGroundSpawn [Random.Range (1, greenGroundSpawn.Length)];
					GameObject newSpawn = theObjectPool.GetCoin();

					if (goodsPrefab == greenGroundSpawn [1]) {
						newSpawn = theObjectPool.GetWoodenBox ();
					} else if (goodsPrefab == greenGroundSpawn [2]) {
						newSpawn = theObjectPool.GetKnight3 ();
					}
					newSpawn.transform.position = pos;
					newSpawn.transform.rotation = transform.rotation;
					newSpawn.SetActive (true);

				}
				spawnPos += 2.4f;
			}
			for (int x = 0; x < numberOfHearts; x++) {
				Vector2 pos = new Vector2 (Random.Range (xMin, xMax), Random.Range (yMin, 2.5f));
				GameObject newSpawn = theObjectPool.GetHeart();
				newSpawn.transform.position = pos;
				newSpawn.transform.rotation = transform.rotation;
				newSpawn.SetActive (true);
			}
			for (int x = 0; x < numberOfChests; x++) {
				Vector2 pos = new Vector2 (Random.Range (xMin, xMax), Random.Range (yMin, 2.5f));
				GameObject newSpawn = theObjectPool.GetChest();
				newSpawn.transform.position = pos;
				newSpawn.transform.rotation = transform.rotation;
				newSpawn.SetActive (true);
			}
		}

		//Red level loads:////////////////////////------------------------------------------------------------
		if (walkWayLoadsIncrement >= 7) {
			for (int i = 0; i < numberOfSpawnPositions; i++) {
				for (int x = 0; x < redNumberOfObstacles; x++) {
					Vector2 pos = new Vector2 (Random.Range (xMin, xMax), spawnPos);
					GameObject goodsPrefab = redGroundSpawn [Random.Range (1, redGroundSpawn.Length)];
					GameObject newSpawn = theObjectPool.GetWoodenBox();
					if (goodsPrefab == redGroundSpawn [1]) {
						newSpawn = theObjectPool.GetCoin ();
					} else if (goodsPrefab == redGroundSpawn [2]) {
						newSpawn = theObjectPool.GetWoodenBox ();
					}

					newSpawn.transform.position = pos;
					newSpawn.transform.rotation = transform.rotation;
					newSpawn.SetActive (true);

				}
				spawnPos += 2.4f;
			}
			for (int x = 0; x < numberOfBosses; x++) {
				Vector2 pos = new Vector2 (Random.Range (xMin, xMax), Random.Range(yMin, yMax));
				GameObject newSpawn = theObjectPool.GetKnight4();

				newSpawn.transform.position = pos;
				newSpawn.transform.rotation = transform.rotation;
				newSpawn.SetActive (true);
			}
		}
	} 
}