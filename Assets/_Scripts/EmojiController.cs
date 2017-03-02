using UnityEngine;
using System.Collections;
using DigitalRuby.SoundManagerNamespace;

public class EmojiController : MonoBehaviour {

	public int level;
	public GameObject text;
	public GameObject naechstesLevel;
	public AudioSoundManager audioman;

	void OnTriggerEnter2D(Collider2D other) {
		
		if (other.gameObject.CompareTag ("Pick Up")) {

			Debug.Log("Trigger ausgeloest");
			other.gameObject.SetActive (false);
			text.SetActive (true);
			naechstesLevel.SetActive (true);
			audioman.PlaySound (1);

			if (PlayerPrefs.GetInt("level") < level) {
				PlayerPrefs.SetInt ("level", level);
				Debug.Log ("saveLevel " + level);

			}
		}
	}
}

