using UnityEngine;
using System.Collections;

public class laserScript : MonoBehaviour {
	public float speed;
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (transform.up * speed);
	}

	void Update () {
		//rb.AddForce (transform.up * speed);
	}

	void OnBecameInvisible() {
		Destroy (gameObject);
	}
}
