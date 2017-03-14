using System.Collections;
using System.Collections.Generic;
using UnityEngine;   
using UnityEngine.SceneManagement;
using DigitalRuby.SoundManagerNamespace;

//Beim App-Start, Musikstart

public class startMusic : MonoBehaviour {
	static int loadingstatus=0; //Speicherung, ob App bereits gestartet wurde
	public AudioSoundManager soundmanager;
	// Use this for initialization

	void Start () {
		//nur beim ersten mal, nicht bei jedem Rückschritt ins Menü
		if(loadingstatus==0)
			//Musikstart
			soundmanager.PlayMusic (0);
		loadingstatus++;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
