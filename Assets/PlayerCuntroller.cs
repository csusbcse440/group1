using UnityEngine;
using System.Collections;

public class PlayerCuntroller : MonoBehaviour 
{
	public float speed;
	public float timer;

	private Rigidbody rb;

	public KeyCode jump;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed); //Make your guy move 

		if (Input.GetKeyDown (jump)) 
		{
			transform.rotation = Quaternion.identity;
			rb.AddForce (transform.up * 500.0f);
		}

		if (timer > 0.0f) 
		{
			timer -= Time.deltaTime;
		}
		if (timer <= 0.0f) 
		{
			speed = 10.0f;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag ("Pickup"))
		{
			speed += 10.0f;

			timer = 15.0f;

			other.gameObject.SetActive (false);
		}
	}
}
