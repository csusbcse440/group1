using UnityEngine;
using System.Collections;

public class CameraCuntroller : MonoBehaviour 
{

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - player.transform.position; // Distance of camera - player
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = player.transform.position + offset;
	}
}
