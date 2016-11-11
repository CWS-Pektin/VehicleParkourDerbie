using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MMButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ToGame () {
		SceneManager.LoadScene ("Normal Scene");
	}
	public void ToCharacters () {
		SceneManager.LoadScene ("Character Scene");
	}
	public void ToCredits () {
		SceneManager.LoadScene ("Credit Scene");
	}
}
