using UnityEngine;
using System.Collections;

public class testing : MonoBehaviour 
{
	public float speed;

	//private Rigidbody rb;
	private Rigidbody2D rb;

	//public KeyCode jump;

	//public float timer;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		/*float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		Vector3 spawn = new Vector3 (-0.1f, 3.5f, 1.2f);

		rb.AddForce (movement * speed);

		if (Input.GetKeyDown (jump)) 
		{*/
			//transform.rotation = Quaternion.identity;
			rb.AddForce (transform.up * speed);
		//}

		/*if (timer >= 0) 
		{
			timer -= Time.deltaTime;
		}
		if (timer <= 0.0f)
		{
			speed = 10.0f;
			rb.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		}
		if (rb.position.y < -20.0f) 
		{
			rb.velocity = new Vector3(0f,0f,0f);
			rb.position = spawn;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("PickupSpeedUp"))
		{
			speed += 10.0f;
			timer = 15.0f;
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.CompareTag("PickupMinimize"))
		{
			timer = 10.0f;
			rb.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.CompareTag("PickupRespawn"))
		{
			Vector3 spawn = new Vector3 (-0.1f, 3.5f, 1.2f);
			rb.velocity = new Vector3(0f,0f,0f);
			rb.position = spawn;
			other.gameObject.SetActive (false);
		}*/
	}
}
