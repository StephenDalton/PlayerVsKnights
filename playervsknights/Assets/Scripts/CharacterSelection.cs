using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Text.RegularExpressions;

public class CharacterSelection : MonoBehaviour {
	
	public Text displayText;
	public Text characterTitle;
	public InputField chosenUserName;
	public string username;
	public GameObject usernameScreen;
	public GameObject unlockBotton;
	public GameObject usernameError;

	public void DisplayText() {
		string name = EventSystem.current.currentSelectedGameObject.tag;
		if (name == "Wizard") {
			characterTitle.text = "Wizard'o";
			displayText.text = "- Awesome Wizard\n- Shoots Ice Balls\n- Loves killing knights";
			PlayerController.playerID = 0;
			unlockBotton.gameObject.SetActive (false);
		}
		if (name == "Jane") {
			characterTitle.text = "Jane";
			displayText.text = "- Archer\n- Gets higher score bonus for killing knights\n- Loves killing knights";
			PlayerController.playerID = 1;
			if (PlayerPrefs.GetInt ("buyjane") == 0) {
				unlockBotton.gameObject.SetActive (true);
			} else {
				unlockBotton.gameObject.SetActive (false);
			}
		}
		if (name == "Pirate") {
			characterTitle.text = "Pirate John";
			displayText.text = "- Boomerang sword thrower\n- Likes Jane\n- Loves killing knights";
			PlayerController.playerID = 2;
			if (PlayerPrefs.GetInt ("buypirate") == 0) {
				unlockBotton.gameObject.SetActive (true);
			} else {
				unlockBotton.gameObject.SetActive (false);
			}
		}
		if (name == "Aristoppable") {
			characterTitle.text = "Aristoppable";
			displayText.text = "- Starts with 3 extra lives\n- Collects coins automatically around him\n- Wants to steal Knights' Gold";
			PlayerController.playerID = 3;
			if (PlayerPrefs.GetInt ("buyaristoppable") == 0) {
				unlockBotton.gameObject.SetActive (true);
			} else {
				unlockBotton.gameObject.SetActive (false);
			}
		}
		if (name == "RedBeard") {
			characterTitle.text = "Red Beard";
			displayText.text = "- Kills Enemies on contact (Except Gold Knights)\n- Amazing Beard\n- Starts at a higher speed";
			PlayerController.playerID = 4;
			if (PlayerPrefs.GetInt ("buyredbeard") == 0) {
				unlockBotton.gameObject.SetActive (true);
			} else {
				unlockBotton.gameObject.SetActive (false);
			}
		}
		if (name == "Goat") {
			characterTitle.text = "Goat the Viking";
			displayText.text = "- Bomb Thrower\n- Loves explosions\n- Loves killing knights";
			PlayerController.playerID = 5;
			if (PlayerPrefs.GetInt ("buygoat") == 0) {
				unlockBotton.gameObject.SetActive (true);
			} else {
				unlockBotton.gameObject.SetActive (false);
			}
		}
	}

	public void Awake () {
		if (PlayerPrefs.GetInt("usernamechosen") == 1) {
			usernameScreen.gameObject.SetActive (false);
		} else {
			usernameScreen.gameObject.SetActive (true);
		}
	}

	void Start () {
		displayText.text = "";
		characterTitle.text = "";
	}

	public void setUsername() {
		//check if username has been chosen yet
		if (PlayerPrefs.GetInt("usernamechosen") != 1) {
			if (chosenUserName.text.Length > 2 && chosenUserName.text.Length < 11) {
				//Check if username contains an *, dreamlo highscoreboard cant accept *'s in usernames
				chosenUserName.text = Regex.Replace(chosenUserName.text, @"\*", "." );
				PlayerPrefs.SetString ("username", chosenUserName.text);
				PlayerPrefs.SetInt ("usernamechosen", 1);
				usernameScreen.gameObject.SetActive (false);
			} else {
				usernameError.gameObject.SetActive (true);
			}
		}
	}

	public void closePopUp() {
		usernameError.gameObject.SetActive (false);
	}

}
