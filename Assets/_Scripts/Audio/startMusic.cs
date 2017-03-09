using System.Collections;
using System.Collections.Generic;
using UnityEngine;   
using UnityEngine.SceneManagement;
using DigitalRuby.SoundManagerNamespace;

public class startMusic : MonoBehaviour {
	static int loadingstatus=0;
	public AudioSoundManager soundmanager;
	// Use this for initialization
	void Start () {
		if(loadingstatus==0)
			soundmanager.PlayMusic (0);
		loadingstatus++;
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnEnable(){


	}
}
