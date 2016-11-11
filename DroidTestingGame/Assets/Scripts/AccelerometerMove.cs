using UnityEngine;
using System.Collections;

public class AccelerometerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float temp = Input.acceleration.x;
		transform.Translate (0, 0, temp);
	}
}
