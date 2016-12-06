﻿using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {
	public float speed;
	private Rigidbody2D rb;
	//public GameObject bomb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (transform.forward * speed);
	}

	void Update () {
		//rb.AddForce (transform.up * speed);
	}

	void OnBecameInvisible() {
		Destroy (gameObject);
	}
		
	void OnTriggerEnter2D(Collider2D other) {
		// If the enemy collided with a bullet
		if (other.gameObject.name == "Green_laser(Clone)") {
			// Destroy itself (the enemy) and the bullet
			if (gameObject.name == "missile 1(Clone)") {
				Destroy (gameObject);
				Destroy (GameObject.Find ("Green_laser(Clone)"));
			}
			if (gameObject.name == "bomb(Clone)") {
				GameObject bomb = GameObject.Find("bomb(Clone)");
				bombHealth bh = bomb.GetComponent<bombHealth>();
				bh.bomb -= 1;
				if (bh.bomb <= 0) {
					Destroy (gameObject);
				}
				Destroy (GameObject.Find ("Green_laser(Clone)"));
			}
		}
	}
}
