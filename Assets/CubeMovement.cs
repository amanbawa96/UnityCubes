using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 move = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f );

		rb.AddForce (move*speed);
	}
}
