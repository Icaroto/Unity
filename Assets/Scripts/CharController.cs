﻿using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {


	void Update() {
//		float step = speed * Time.deltaTime;
//		Vector3 onde = new Vector3 (10, 10, 10);
//		transform.position = Vector3.MoveTowards(transform.position,onde, step);
	}
	// Use this for initialization
	void Start () {
	
	}

    public void HideCharacter(bool isInteracting)
    {
        gameObject.SetActive(!isInteracting);
    }

}