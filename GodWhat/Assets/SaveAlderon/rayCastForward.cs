using UnityEngine;
using System.Collections;

public class rayCastForward : MonoBehaviour {

	public Transform cannonStart, cannonEnd, laserSpawn;
	public Rigidbody2D laser;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Raycasting ();

		Vector2 cannonEnd = GameObject.Find ("cannonEnd").transform.position;
		//cannonEnd.z = 0;
		Vector2 formRightTriangle = cannonEnd;
		//Debug.Log (cannonEnd);
		formRightTriangle.y = GameObject.Find ("pivotPoint").transform.position.y;
		Vector2 pivotPoint = GameObject.Find ("pivotPoint").transform.position;

		Debug.DrawLine (cannonStart.position, formRightTriangle, Color.red); //adjacent
		Debug.DrawLine (cannonEnd, formRightTriangle, Color.blue); //opposite
		Debug.DrawLine (cannonEnd, cannonStart.position, Color.yellow); //opposite

		float hypotenuseDistance = Vector2.Distance (cannonEnd, cannonStart.position);
		//Debug.Log (hypotenuseDistance);

		float oppositeDistance = Vector2.Distance (cannonEnd, formRightTriangle);
		//Debug.Log (oppositeDistance);

		float sin = Mathf.Asin (oppositeDistance / hypotenuseDistance);
		sin = sin * 180 / Mathf.PI;

		//if (cannonEnd.y < -5) {
			//Debug.Log ("false");
		//} else if (cannonEnd.y > -5) {
			//Debug.Log ("true");
		//}

		if (cannonEnd.x < 17 && cannonEnd.y > -7.6) {
			GameObject.Find ("pivotPoint").transform.eulerAngles = new Vector3 (0, 0, (90 - sin));
			//Debug.Log ("sin " + sin);
		} else if (cannonEnd.x >= 17 && cannonEnd.y > -7.6) {
			GameObject.Find ("pivotPoint").transform.eulerAngles = new Vector3 (0, 0, (sin - 90));
			//Debug.Log ("sin " + sin);
		} 

		if (Input.GetMouseButtonDown (0)) {
			Rigidbody2D laserBlast = Instantiate (laser, laserSpawn.transform.position, transform.rotation) as Rigidbody2D;
			GetComponent<AudioSource>().Play();
			//WaitForSecondsRealtime (1);
		}

		//Debug.Log ("counter " + counter);
		//Debug.Log ("fireOnce " + fireOncePerSecond);

	}

	void Raycasting() {
		Debug.DrawLine (cannonStart.position, cannonEnd.position, Color.green); //hypotenuse
	}
}
