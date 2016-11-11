using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class DeathMenu : MonoBehaviour {

	public Text scoreText;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleEndMenu(float score) {
		gameObject.SetActive (true);
		scoreText.text = ((int)score).ToString ();
	}

	public void Restart() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void ToMenu() {
		SceneManager.LoadScene ("MainMenu");
	}
}
