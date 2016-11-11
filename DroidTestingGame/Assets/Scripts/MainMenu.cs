using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Text highscoreText;

	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		highscoreText.text = "Highscore: " + ((int)PlayerPrefs.GetFloat ("Highscore")).ToString();
	}
}
