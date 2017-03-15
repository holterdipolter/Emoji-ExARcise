using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// verkleinert Emoji, wenn der Sendbutton berührt wurde

public class EmojiShrink : MonoBehaviour {

	public GameObject emoji;
	private Vector3 size;
	int j; //zählvariable
	public int Geschwindigkeit;

	// Use this for initialization
	void Start () {
		size = emoji.transform.localScale;
		j = 0;

	}

	// Update is called once per frame
	void Update () {
		if(j<50)
		j++;
		//Größenreduktion
		size.x = size.x - Geschwindigkeit;
		size.y = size.y - Geschwindigkeit;
		emoji.transform.localScale = size;
		//wenn auf 0 geschrumpft, ausblenden
		if (size.x <= 0)
			emoji.SetActive (false);
		
		
	}
}
