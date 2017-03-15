using UnityEngine;
using System.Collections;
using DigitalRuby.SoundManagerNamespace;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EmojiController : MonoBehaviour {

	// fuehrt verschiedene Aktionen, die vom Emoji ausgelöst werden:
	// - "Gewonnen"-Animation auslösen, wenn Send-Button (Ziel) erreicht
	// - "Emoji-Shrink"-Animation auslösen, wenn Send-Button (Ziel) erreicht
	// - Gravity Wert verändern, wenn im Bereich eines Gravity-Felds
	// - UI-Restart-Button aktivieren, wenn Emoji gestartet wird
	// - Audio-Aktionen auslösen
	// - wenn Level erfolgreich, speichere Level in PlayerPrefs

	public GameObject sendButton;
	public GameObject naechstesLevel;
	public GameObject tos;
	public GameObject gewonnen;
	public GameObject restartEmojiButton;
	public GameObject shrinker;
	public AudioSoundManager audioman;

	private Button emojiButton;
	private int level;
	private Rigidbody2D rigidb;
	private float gravityAwake;
	private TriggerValues gravityNew;

	void Awake ()
	{
		// Speichere gravityScale-Wert
		rigidb = GetComponent<Rigidbody2D>();
		gravityAwake = rigidb.gravityScale;

		// Speichere Level anhand des buildIndex der Szene
		level = SceneManager.GetActiveScene().buildIndex;

		// Speichere UI-BUtton "restartEmojiButton"
		emojiButton = restartEmojiButton.GetComponent<Button>();

	}

	void OnTriggerEnter2D(Collider2D other) {

		// Wenn Send-Button beruehrt wird:
		if (other.gameObject.CompareTag ("Pick Up")) {
			// - "Gewonnen"-Animation auslösen
			// - "Emoji-Shrink"-Animation auslösen
			// - Audio-Aktionen auslösen
			// - speichere Level in PlayerPrefs

			Debug.Log("Trigger Pick Up");

			gewonnen.SetActive (true);
			naechstesLevel.SetActive (true);
			tos.SetActive (false); 
			shrinker.SetActive(true);
			emojiButton.interactable = false;
			audioman.PlaySound (5);

			if (PlayerPrefs.GetInt("level") < level) {
				PlayerPrefs.SetInt ("level", level);
				Debug.Log ("saveLevel " + level);

			}
		}

		// bei Eintritt in Gravitionsfeld:
		if (other.gameObject.CompareTag ("gravityIn")) {

			Debug.Log ("Trigger gravityIn");

			// Trigger Value (Gravity) auslesen und in Rigidbody setzen
			gravityNew = other.GetComponent<TriggerValues> ();
			rigidb.gravityScale = gravityNew.Gravity;

		} 

		// bei Austritt in Gravitionsfeld (optional):
		if (other.gameObject.CompareTag ("gravityOut")) {

			Debug.Log("Trigger gravityOut");

			// setze Gravity zurück auf Anfangswert
			rigidb.gravityScale = gravityAwake;
		}


		if (other.gameObject.CompareTag ("sendButtonActive")) {

			// Aktivere UI-Restart-Button bzw. deaktiviere UI-Start-Button, wenn UI-Start-Button gedrueckt
			Debug.Log("Trigger sendButtonActive");
			audioman.PlaySound (0);
			sendButton.SetActive (true);
		}
	}


}

