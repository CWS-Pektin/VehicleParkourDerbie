using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour {

	private CharacterController controller;

	private float speed = 35.0f;

	private bool playerIsDead = false;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerIsDead)
			return;

		controller.Move ((Vector3.forward) * Time.deltaTime * speed);
	}
	public void SetSpeed(float modifier){
		speed = 35.0f * modifier;
	}
	private void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.point.z > transform.position.z + (controller.radius/2))
			PlayerDeath ();
	}
	private void PlayerDeath() {
		playerIsDead = true;
		GetComponent<HighscoreManager> ().OnDeath();
	}
}
