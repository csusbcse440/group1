﻿using UnityEngine;
using System.Collections;

public class updateCannonEndPoint : MonoBehaviour {

	//public Transform cannonEndPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mark = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//Debug.Log (mark);
		transform.position = mark;
	}
}
