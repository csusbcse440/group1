using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {

	public KeyCode tiltForward;
	public KeyCode tiltBackward;
	public KeyCode tiltRight;
	public KeyCode tiltLeft;

	private Vector3 pivot;

	// Use this for initialization
	void Start () 
	{
		pivot = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (tiltForward))
		{
			if (pivot.z <= 45.0f)
			{
				pivot.z += 1.0f;
			}
		}

	    if (Input.GetKey (tiltBackward))
		{
			if(pivot.z >= -45.0f)
			{
				pivot.z -= 1.0f;
			}
		}
		
		if (Input.GetKey (tiltRight))
		{
			if (pivot.x <= 45.0f)
			{
				pivot.x += 1.0f;
			}
		}

		if (Input.GetKey (tiltLeft))
		{
			if (pivot.x >= -45.0f)
			{
				pivot.x -= 1.0f;
			}			
		}
		
		transform.rotation = Quaternion.Euler (pivot);
	}
}
