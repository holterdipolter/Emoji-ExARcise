using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfo : MonoBehaviour {

	public void LoadAllInfo(){
		GameInfo.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		Debug.Log ("LOADED ALL INFORMATION");
	}
}

