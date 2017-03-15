using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerValues : MonoBehaviour {

	// Speichert einen Gravity-Value
	// Kann genutzt werden, um einem Gravitionsfeld einen Gravitationswert zuzuweisen
	// wird von EmojiController ausgelesen, wenn der Gravity-Trigger ausgeloest wird

	public float Gravity;

	public float GetGravity(){
		return Gravity;
	}
}
