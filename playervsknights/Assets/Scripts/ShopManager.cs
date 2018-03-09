using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour {

	public Text coinsAmount;
	public GameObject notEnoughCoinsMessage;
	public GameObject janeCheck, pirateCheck, redBeardCheck, aristoppableCheck, goatCheck, jellyCheck;

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
		if (PlayerPrefs.GetInt ("buyjelly") == 1) {
			jellyCheck.gameObject.SetActive (true);
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
		if (PlayerPrefs.GetInt("coins") >= 25 && PlayerPrefs.GetInt("buyjane") == 0) {
			PlayerPrefs.SetInt ("buyjane", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 25);
			janeCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 25 && PlayerPrefs.GetInt("buyjane") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}

	public void buyPirate () {
		if (PlayerPrefs.GetInt("coins") >= 75 && PlayerPrefs.GetInt("buypirate") == 0) {
			PlayerPrefs.SetInt ("buypirate", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 75);
			pirateCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 75 && PlayerPrefs.GetInt("buypirate") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}

	public void buyAristoppable () {
		if (PlayerPrefs.GetInt("coins") >= 150 && PlayerPrefs.GetInt("buyaristoppable") == 0) {
			PlayerPrefs.SetInt ("buyaristoppable", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 150);
			aristoppableCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 150 && PlayerPrefs.GetInt("buyaristoppable") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}

	public void buyRedBeard () {
		if (PlayerPrefs.GetInt("coins") >= 350 && PlayerPrefs.GetInt("buyredbeard") == 0) {
			PlayerPrefs.SetInt ("buyredbeard", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 350);
			redBeardCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 350 && PlayerPrefs.GetInt("buyredbeard") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}

	public void buyGoat () {
		if (PlayerPrefs.GetInt("coins") >= 600 && PlayerPrefs.GetInt("buygoat") == 0) {
			PlayerPrefs.SetInt ("buygoat", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 600);
			goatCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 600 && PlayerPrefs.GetInt("buygoat") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}

	public void buyJelly () {
		if (PlayerPrefs.GetInt("coins") >= 1000 && PlayerPrefs.GetInt("buyjelly") == 0) {
			PlayerPrefs.SetInt ("buyjelly", 1);
			PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 1000);
			jellyCheck.gameObject.SetActive (true);
		} else if (PlayerPrefs.GetInt("coins") < 1000 && PlayerPrefs.GetInt("buyjelly") == 0) {
			notEnoughCoinsMessage.gameObject.SetActive (true);
		}
	}
}
