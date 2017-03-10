using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMute : MonoBehaviour {
	public static bool mute=false;

	public GameObject TonOn;
	public GameObject TonOff;
	public void MuteIt(){
		mute = true;
	}

	public void UnMuteIt(){
		mute = false;
	}
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {

		if (mute) {
			TonOff.SetActive (false);
			TonOn.SetActive (true);

		}
		else
		{
			TonOff.SetActive (true);
			TonOn.SetActive (false);
		}

	}
}
