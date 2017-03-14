using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Deaktivierung/Aktivierung des Audio-An-Aus-Buttons

public class AudioMute : MonoBehaviour {
	public static bool mute=false; //spielübergreifende Variable, Speichern des Mutezustands

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
