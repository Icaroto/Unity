﻿using UnityEngine;
using System.Collections;

public class ObjectController : MonoBehaviour {

	public GameObject character;

	private Vector3 size;
	private Vector3 position;
	private bool shouldmove;
	// Use this for initialization
	void Start () {
		size = GetComponent<Transform> ().localScale;
		position = GetComponent<Transform>().position;
		shouldmove = false;
//		Debug.Log (size);
	}
	
	// Update is called once per frame
	void Update () {
		if (shouldmove) {
			float step = 2 * Time.deltaTime;
			Vector3 onde = new Vector3 (10, 10, 10);
			character.GetComponent<Transform>().position = Vector3.MoveTowards(character.GetComponent<Transform>().position,position, step);
		}
	}

	void OnMouseOver ()
	{
		GetComponent<Renderer>().material.color = Color.yellow;// * Time.deltaTime;
		GetComponent<Transform> ().localScale = size + new Vector3 (0.5f, 0.5f, 0.5f);
		if (Input.GetMouseButtonDown (0)) {
			shouldmove = true;
		}
			
	}
	
	void OnMouseExit ()
	{
		GetComponent<Renderer>().material.color = Color.white;
		GetComponent<Transform> ().localScale = size;
	}

}
