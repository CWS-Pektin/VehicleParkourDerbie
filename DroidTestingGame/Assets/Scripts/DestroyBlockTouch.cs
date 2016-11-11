using UnityEngine;
using System.Collections;

public class DestroyBlockTouch : MonoBehaviour {

	Ray CamRay;
	RaycastHit BlockHit;

	void Start () {
		
	}

	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
		CamRay = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
			Debug.DrawRay (CamRay.origin, CamRay.direction * 40);

			if (Physics.Raycast (CamRay,out BlockHit,Mathf.Infinity)) {
				Debug.Log ("Ein Objekt wurde getroffen.");
				Destroy (BlockHit.transform.gameObject);
			} else {
				Debug.Log ("Das Objekt wurde nicht getroffen.");
			}
		}
	}
}