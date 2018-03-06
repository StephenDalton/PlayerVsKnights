using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour {

	public Text coinsAmount;
	public GameObject notEnoughCoinsMessage;
	public GameObject janeCheck, pirateCheck, redBeardCheck, aristoppableCheck, goatCheck;

	private int numberOfCoins;

	void Start () {
		PlayerPrefs.SetInt ("coins", 1000);
	
		if (PlayerPrefs.GetInt ("buyjane") == 1) {
			janeCheck.gameObject.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("buypirate") == 1) {
			pirateCheck.gameObject.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("buyredbeard") == 1) {
			redBeardCheck.gameObject.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("buyaristoppable") == 1) {
			aristoppableCheck.gameObject.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("buygoat") == 1) {
			goatCheck.gameObject.SetActive (true);
		}
	}

	void Update () {
		numberOfCoins = PlayerPrefs.GetInt("coins");
		coinsAmount.text = "" + numberOfCoins;
	}

	public void CloseCoinMessage () {
		notEnoughCoinsMessage.gameObject.SetActive (false);	
	}

	public void buyJane () {
		if (PlayerPrefs.GetInt("coins") > 25 && PlayerPrefs.GetInt("buyjane") == 0) {
			PlayerPrefs.SetInt ("buyjane", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 25);
			janeCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 25 && PlayerPrefs.GetInt("buyjane") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}

	public void buyPirate () {
		if (PlayerPrefs.GetInt("coins") > 50 && PlayerPrefs.GetInt("buypirate") == 0) {
			PlayerPrefs.SetInt ("buypirate", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 50);
			pirateCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 50 && PlayerPrefs.GetInt("buypirate") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}

	public void buyAristoppable () {
		if (PlayerPrefs.GetInt("coins") > 100 && PlayerPrefs.GetInt("buyaristoppable") == 0) {
			PlayerPrefs.SetInt ("buyaristoppable", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 100);
			aristoppableCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 100 && PlayerPrefs.GetInt("buyaristoppable") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}

	public void buyRedBeard () {
		if (PlayerPrefs.GetInt("coins") > 300 && PlayerPrefs.GetInt("buyredbeard") == 0) {
			PlayerPrefs.SetInt ("buyredbeard", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 300);
			redBeardCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 300 && PlayerPrefs.GetInt("buyredbeard") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}

	public void buyGoat () {
		if (PlayerPrefs.GetInt("coins") > 500 && PlayerPrefs.GetInt("buygoat") == 0) {
			PlayerPrefs.SetInt ("buygoat", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 500);
			goatCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 500 && PlayerPrefs.GetInt("buygoat") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}
}
