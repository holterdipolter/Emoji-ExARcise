using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo : MonoBehaviour  {

	public void SaveAllInfo(){
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInfo.PlayerLevel);
		Debug.Log("SAVED ALL INFORMATION");
		Debug.Log("GAMEINFO PLAYER:" + GameInfo.PlayerLevel);
	}
}
