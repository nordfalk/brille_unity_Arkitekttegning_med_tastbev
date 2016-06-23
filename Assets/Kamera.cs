using UnityEngine;
using System.Collections;

public class Kamera : MonoBehaviour {

	float minVariabel;

	// Use this for initialization
	void Start () {
		Debug.Log("Hurra 0 ");
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log("enter ");
		if (Input.GetButtonDown ("Fire1")) {
			Debug.Log("Hurra hurra ");
			/*
			float h = Input.GetAxis ("Horizontal");
			float v = Input.GetAxis ("Vertical");

			h = h + 0.01f;
						*/
			Vector3 move = new Vector3 (1000, 0, 0);
			transform.Translate (move * Time.deltaTime);
		}			

		float h = Input.GetAxis ("Horizontal"); // aflæser tasterne ad
		float v = Input.GetAxis ("Vertical");   // aflæser tasterne sw
		Vector3 move2 = new Vector3 (100*h, 100*v, 0);
		transform.Translate (move2 );

	}
}
