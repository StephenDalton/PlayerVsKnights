using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class dreamloLeaderBoard : MonoBehaviour {
	
	string dreamloWebserviceURL = "http://dreamlo.com/lb/";
	
	public string privateCode = "t1vduP4M-0mETiku2_iu3QI0ZFXBJ6zUWAMMOT_07sFg";
	public string publicCode = "5a95b21939992d09e4f02f17";
	
	public HighScore[] highscoresList;
	static dreamloLeaderBoard instance;
	DisplayHighscores highscoresDisplay;
	////////////////////////////////////////////////////////////////////////////////////////////////
	
	// A player named Carmine got a score of 100. If the same name is added twice, we use the higher score.
 	// http://dreamlo.com/lb/(your super secret very long code)/add/Carmine/100

	// A player named Carmine got a score of 1000 in 90 seconds.
 	// http://dreamlo.com/lb/(your super secret very long code)/add/Carmine/1000/90
	
	// A player named Carmine got a score of 1000 in 90 seconds and is Awesome.
 	// http://dreamlo.com/lb/(your super secret very long code)/add/Carmine/1000/90/Awesome
	
	////////////////////////////////////////////////////////////////////////////////////////////////
	
	void Awake () {
		instance = this;
		AddNewHighScore ("Ashleigh", 400000);
		highscoresDisplay = GetComponent<DisplayHighscores> ();
	}

	public static void AddNewHighScore (string username, int score) {
		instance.StartCoroutine (instance.UploadNewHighscore (username, score));
	}


	IEnumerator UploadNewHighscore (string username, int score) {
		WWW www = new WWW(dreamloWebserviceURL + privateCode + "/add/" + WWW.EscapeURL(username) + "/" + score);
		yield return www;

		if (string.IsNullOrEmpty (www.error)) {
			print ("Score Uploaded");
			DownloadHighScores();
		} else {
			print ("Error Uploading: " + www.error);
		}
	}
	public void DownloadHighScores () {
		StartCoroutine ("DownloadHighscoresFromDatabase");
	}


	IEnumerator DownloadHighscoresFromDatabase () {
		WWW www = new WWW(dreamloWebserviceURL + publicCode + "/pipe/");
		yield return www;

		if (string.IsNullOrEmpty (www.error)) {
			FormatHighScores (www.text);
			highscoresDisplay.OnHighscoresDownloaded (highscoresList);
		} else {
			print ("Error Downloading Scores : " + www.error);
		}
	}

	void FormatHighScores (string textStream) {
		string[] entries = textStream.Split (new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
		highscoresList = new HighScore[entries.Length];

		for (int i = 0; i < entries.Length; i++) {
			string[] entryInfo = entries [i].Split (new char[] { '|' });
			string username = entryInfo [0];
			int score = int.Parse(entryInfo[1]);
			highscoresList [i] = new HighScore (username, score);
			//print (highscoresList[i].username + ": " + highscoresList [i].score);
		}
	}
		
}

public struct HighScore {
	public string username;
	public int score;

	public HighScore(string _username, int _score) {
		username = _username;
		score = _score;
	}
}