﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmojiShrink : MonoBehaviour {

	public GameObject emoji;
	private Vector3 size;
	int j;

	// Use this for initialization
	void Start () {
		size = emoji.transform.localScale;
		j = 0;

	}

	void shrinkEmoji(){



	}
	
	// Update is called once per frame
	void Update () {
		if(j<50)
		j++;
		
		size.x = size.x - 1f;
		size.y = size.y - 1f;
		emoji.transform.localScale = size;
		if (size.x <= 0)
			emoji.SetActive (false);
		
		
	}
}