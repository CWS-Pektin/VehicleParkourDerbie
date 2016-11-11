using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighscoreManager : MonoBehaviour {

	private float score = 0.0f;

	private int difficultyLevel = 1;
	private int maxDifficultyLevel = 5;
	private int scoreToNextLevel = 20;

	private bool playerIsDead = false;

	public Text scoreText;
	public DeathMenu deathMenu;

	void Update () {

		if (playerIsDead)
			return;

		if (score >= scoreToNextLevel)
			GetLevelUp ();
		score += Time.deltaTime;
		scoreText.text = ((int)score).ToString ();
	}

	void GetLevelUp(){

		if (difficultyLevel == maxDifficultyLevel)
			return;
		
		scoreToNextLevel *= 10;
		difficultyLevel++;


		GetComponent<PlayerMotor> ().SetSpeed (difficultyLevel);
		//Debug.Log ("Du spielst nun auf Level " + difficultyLevel + ".");
	}
	public void OnDeath() {
		playerIsDead = true;
		if(PlayerPrefs.GetFloat("Highscore") < score)
		    PlayerPrefs.SetFloat("Highscore",score);
		
		deathMenu.ToggleEndMenu (score);
	}
}
