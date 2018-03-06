using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettingsMenu : MonoBehaviour {
	public Toggle soundToggle;
	public GameObject feedbackWindow;
		
	void Awake () {
		if (PlayerPrefs.GetInt ("audio") == 0) {
			soundToggle.isOn = false;
			AudioListener.pause = true;
		}
		if (PlayerPrefs.GetInt ("audio") == 1) {
			soundToggle.isOn = true;
			AudioListener.pause = false;
		}
	}

	public void soundToggleChange (bool mute) {
		if (soundToggle.isOn == true) {
			AudioListener.pause = false;
			PlayerPrefs.SetInt ("audio", 1);
		}
		if (soundToggle.isOn == false) {
			AudioListener.pause = true;
			PlayerPrefs.SetInt ("audio", 0);
		}
	}

	public void openFeedbackWindow () {
		feedbackWindow.gameObject.SetActive (true);
	}

	public void closeFeedbackWindow () {
		feedbackWindow.gameObject.SetActive (false);
	}

	public void goToFeedBackURL () {
		Application.OpenURL ("www.stomt.com/playervsknights");
	}
	public void resetUsername() {
		PlayerPrefs.DeleteKey ("username");
		PlayerPrefs.SetInt ("usernamechosen", 0);
		PlayerPrefs.DeleteKey ("highscore");
		PlayerPrefs.SetInt ("buyjane", 0);
		PlayerPrefs.SetInt ("buypirate", 0);
		PlayerPrefs.SetInt ("buyaristoppable", 0);
		PlayerPrefs.SetInt ("buyredbeard", 0);
		PlayerPrefs.SetInt ("buygoat", 0);

	}

}
