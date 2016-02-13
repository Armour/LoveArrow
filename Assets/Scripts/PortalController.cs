﻿using UnityEngine;
using System.Collections;

public class PortalController : MonoBehaviour {

	public GameObject anotherPortal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		Vector3 offset = coll.gameObject.transform.position - transform.position;
		offset.x = -offset.x;
		coll.gameObject.transform.position = anotherPortal.transform.position + offset;
	}
}