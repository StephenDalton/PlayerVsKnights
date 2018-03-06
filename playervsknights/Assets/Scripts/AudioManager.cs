using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

	float currentMusicTime;

	public GameObject musicPlayer;
	public static AudioManager instance;

	void Awake() {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
			return;
		}
	}

	void Update () {
		GameObject[] objs = GameObject.FindGameObjectsWithTag ("GameAudio");
		if (objs.Length > 0) {
			Destroy (this.gameObject);
		}
	}
		
}
