﻿using UnityEngine;
using System.Collections;
using HelperStuffs;
public class InputManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/// TODO: Put outside Update?
		if(Input.GetKeyUp(KeyCode.Space))
		{
			Helper.getGameManager().GoRight();
		}
	}
}
