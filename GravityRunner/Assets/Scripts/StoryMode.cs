﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryMode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 0f;
	}

	public void StartTimeScale()
	{
		Time.timeScale = 1f;
	}
}
