using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Animator anima;
	public float velocidadeMov;

	// Use this for initialization
	void Start () {
		anima = this.GetComponent<Animator> ();
		velocidadeMov = 0.1f;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (0, 0, velocidadeMov);
			anima.SetBool ("running", true);
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			anima.SetBool ("running", false);
		}
		if ((Input.GetKey (KeyCode.D)) && (Input.GetKeyUp(KeyCode.LeftShift))) {
			transform.Translate (0, 0, (2 * velocidadeMov));
			anima.SetBool ("sprinting", true);
		}
		if ((Input.GetKeyUp (KeyCode.D)) && (Input.GetKeyUp(KeyCode.LeftShift))) {
			anima.SetBool ("sprinting", false);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, 0, (-1 * velocidadeMov));
			anima.SetBool ("backward", true);
		}
		if (Input.GetKeyUp (KeyCode.S)) {
			anima.SetBool ("backward", false);
		}
		if (Input.GetKey (KeyCode.Space)) {
			anima.SetBool ("shooting", true);
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			anima.SetBool ("shooting", false);
		}
		if (Input.GetKey (KeyCode.K)) {
			transform.Translate (0, 0, 0.02f);
			anima.SetBool ("rolling", true);
		}
		if (Input.GetKeyUp (KeyCode.K)) {
			anima.SetBool ("rolling", false);
		}
	}
}