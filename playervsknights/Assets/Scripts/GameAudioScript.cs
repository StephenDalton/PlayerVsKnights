using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameAudioScript : MonoBehaviour {
	private float delay = 1;

	void Awake () {
		AudioSource audio = GetComponent<AudioSource> ();
		audio.PlayDelayed (delay);
	}
}
