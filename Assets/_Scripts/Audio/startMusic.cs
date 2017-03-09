using System.Collections;
using System.Collections.Generic;
using UnityEngine;   
using UnityEngine.SceneManagement;
using DigitalRuby.SoundManagerNamespace;

public class startMusic : MonoBehaviour {

	public AudioSoundManager soundmanager;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnEnable(){
		soundmanager.PlayMusic (0);
	}
}
