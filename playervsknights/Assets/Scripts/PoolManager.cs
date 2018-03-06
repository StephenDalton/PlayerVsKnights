using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour {

	public GameObject blueWalkWay;
	public GameObject greenWalkWay;
	public GameObject redWalkWay;
	public int pooledWalkWayAmount;

	public GameObject knight1, knight2, knight3, knight4, heart, coins, woodenBox, chest;
	public int pooledKnightBoxCoinAmount;
	public int pooledHeartAmount;

	List<GameObject> pooledBlues;
	List<GameObject> pooledGreens;
	List<GameObject> pooledReds;
	List<GameObject> pooledKnight1s;
	List<GameObject> pooledKnight2s;
	List<GameObject> pooledKnight3s;
	List<GameObject> pooledKnight4s;
	List<GameObject> pooledHearts;
	List<GameObject> pooledChests;
	List<GameObject> pooledCoins;
	List<GameObject> pooledWoodenBoxes;


	void Awake () {
		pooledBlues = new List<GameObject> ();
		pooledGreens = new List<GameObject>();
		pooledReds = new List<GameObject>();
		pooledKnight1s = new List<GameObject>();
		pooledKnight2s = new List<GameObject>();
		pooledKnight3s = new List<GameObject>();
		pooledKnight4s = new List<GameObject>();
		pooledHearts = new List<GameObject>();
		pooledChests = new List<GameObject>();
		pooledCoins = new List<GameObject>();
		pooledWoodenBoxes = new List<GameObject>();

		for (int i = 0; i < pooledWalkWayAmount; i++) {
			GameObject obj0 = (GameObject)Instantiate (blueWalkWay);
			GameObject obj1 = (GameObject)Instantiate (greenWalkWay);
			GameObject obj2 = (GameObject)Instantiate (redWalkWay);
			obj0.SetActive (false);
			obj1.SetActive (false);
			obj2.SetActive (false);
			pooledBlues.Add (obj0);
			pooledGreens.Add (obj1);
			pooledReds.Add (obj2);
		}
		for (int i = 0; i < pooledKnightBoxCoinAmount; i++) {
			GameObject obj0 = (GameObject)Instantiate (knight1);
			GameObject obj1 = (GameObject)Instantiate (knight2);
			GameObject obj2 = (GameObject)Instantiate (knight3);
			GameObject obj3 = (GameObject)Instantiate (knight4);
			GameObject obj4 = (GameObject)Instantiate (coins);
			GameObject obj5 = (GameObject)Instantiate (woodenBox);
			obj0.SetActive (false);
			obj1.SetActive (false);
			obj2.SetActive (false);
			obj3.SetActive (false);
			obj4.SetActive (false);
			obj5.SetActive (false);
			pooledKnight1s.Add (obj0);
			pooledKnight2s.Add (obj1);
			pooledKnight3s.Add (obj2);
			pooledKnight4s.Add (obj3);
			pooledCoins.Add (obj4);
			pooledWoodenBoxes.Add (obj5);
		}
		for (int i = 0; i < pooledHeartAmount; i++) {
			GameObject obj0 = (GameObject)Instantiate (heart);
			GameObject obj1 = (GameObject)Instantiate (chest);
			obj0.SetActive (false);
			pooledBlues.Add (obj0);
			obj1.SetActive (false);
			pooledBlues.Add (obj1);
		}
	}

	public GameObject GetBlueWalkWay() {
		for (int i = 0; i < pooledBlues.Count; i++) {
			if (!pooledBlues[i].activeInHierarchy) {
				return pooledBlues[i];
			}
		}
		GameObject obj0 = (GameObject)Instantiate (blueWalkWay);
		obj0.SetActive (false);
		pooledBlues.Add (obj0);
		return obj0;
	}

	public GameObject GetGreenWalkWay() {
		for (int i = 0; i < pooledGreens.Count; i++) {
			if (!pooledGreens [i].activeInHierarchy) {
				return pooledGreens [i];
			}
		}
		GameObject obj = (GameObject)Instantiate (greenWalkWay);
		obj.SetActive (false);
		pooledGreens.Add (obj);
		return obj;
	}

	public GameObject GetRedWalkWay() {
		for (int i = 0; i < pooledReds.Count; i++) {
			if (!pooledReds [i].activeInHierarchy) {
				return pooledReds [i];
			}
		}
		GameObject obj = (GameObject)Instantiate (redWalkWay);
		obj.SetActive (false);
		pooledReds.Add (obj);
		return obj;
	}

	// ------------------------------------------------------------------

	public GameObject GetKnight1() {
		for (int i = 0; i < pooledKnight1s.Count; i++) {
			if (!pooledKnight1s [i].activeInHierarchy) {
				return pooledKnight1s [i];
			}
		}
		GameObject obj = (GameObject)Instantiate (knight1);
		obj.SetActive (false);
		pooledKnight1s.Add (obj);
		return obj;
	}

	public GameObject GetKnight2() {
		for (int i = 0; i < pooledKnight2s.Count; i++) {
			if (!pooledKnight2s [i].activeInHierarchy) {
				return pooledKnight2s [i];
			}
		}
		GameObject obj = (GameObject)Instantiate (knight2);
		obj.SetActive (false);
		pooledKnight2s.Add (obj);
		return obj;
	}

	public GameObject GetKnight3() {
		for (int i = 0; i < pooledKnight3s.Count; i++) {
			if (!pooledKnight3s [i].activeInHierarchy) {
				return pooledKnight3s [i];
			}
		}
		GameObject obj = (GameObject)Instantiate (knight3);
		obj.SetActive (false);
		pooledKnight3s.Add (obj);
		return obj;
	}

	public GameObject GetKnight4() {
		for (int i = 0; i < pooledKnight4s.Count; i++) {
			if (!pooledKnight4s [i].activeInHierarchy) {
				return pooledKnight4s [i];
			}
		}
		GameObject obj = (GameObject)Instantiate (knight4);
		obj.SetActive (false);
		pooledKnight4s.Add (obj);
		return obj;
	}

	public GameObject GetCoin() {
		for (int i = 0; i < pooledCoins.Count; i++) {
			if (!pooledCoins [i].activeInHierarchy) {
				return pooledCoins [i];
			}
		}
		GameObject obj = (GameObject)Instantiate (coins);
		obj.SetActive (false);
		pooledCoins.Add (obj);
		return obj;
	}

	public GameObject GetWoodenBox() {
		for (int i = 0; i < pooledWoodenBoxes.Count; i++) {
			if (!pooledWoodenBoxes [i].activeInHierarchy) {
				return pooledWoodenBoxes [i];
			}
		}
		GameObject obj = (GameObject)Instantiate (woodenBox);
		obj.SetActive (false);
		pooledWoodenBoxes.Add (obj);
		return obj;
	}
	public GameObject GetHeart() {
		for (int i = 0; i < pooledHearts.Count; i++) {
			if (!pooledHearts [i].activeInHierarchy) {
				return pooledHearts [i];
			}
		}
		GameObject obj = (GameObject)Instantiate (heart);
		obj.SetActive (false);
		pooledHearts.Add (obj);
		return obj;
	} 

	public GameObject GetChest() {
		for (int i = 0; i < pooledChests.Count; i++) {
			if (!pooledHearts [i].activeInHierarchy) {
				return pooledChests [i];
			}
		}
		GameObject obj = (GameObject)Instantiate (chest);
		obj.SetActive (false);
		pooledHearts.Add (obj);
		return obj;
	} 

}
