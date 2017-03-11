using UnityEngine;
using System.Collections;
using DigitalRuby.SoundManagerNamespace;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EmojiController : MonoBehaviour {

	public GameObject naechstesLevel;
	public GameObject tangibleObjects;
	public GameObject gewonnen;
	public GameObject restartEmojiButton;
	public AudioSoundManager audioman;

	public GameObject TriggerX1;
	public GameObject TriggerX2;
	public GameObject TriggerX3;
	public GameObject TriggerX4;

	public GameObject Shrinker;

	private Button emojiButton;
	private int level;
	private Rigidbody2D rigidb;
	private float gravityAwake;
	private TriggerValues gravityNew;

	void Awake ()
	{
		rigidb = GetComponent<Rigidbody2D>();
		gravityAwake = rigidb.gravityScale;

		level = SceneManager.GetActiveScene().buildIndex;

		emojiButton = restartEmojiButton.GetComponent<Button>();

	}

	void OnTriggerEnter2D(Collider2D other) {
		
		if (other.gameObject.CompareTag ("Pick Up")) {

			Debug.Log("Trigger Pick Up");
			//TriggerX4.SetActive (true);

			//other.gameObject.SetActive (false);
			gewonnen.SetActive (true);
			naechstesLevel.SetActive (true);
			tangibleObjects.SetActive (false); 
			//this.gameObject.SetActive (false);
			Shrinker.SetActive(true);
			emojiButton.interactable = false;
			audioman.PlaySound (5);

			if (PlayerPrefs.GetInt("level") < level) {
				PlayerPrefs.SetInt ("level", level);
				Debug.Log ("saveLevel " + level);

			}
		}

		if (other.gameObject.CompareTag ("gravityIn")) {

			Debug.Log ("Trigger gravityIn");
			//TriggerX1.SetActive (true);

			gravityNew = other.GetComponent<TriggerValues> ();
			rigidb.gravityScale = gravityNew.Gravity;

			//TriggerX3.SetActive (true);

		} 

		if (other.gameObject.CompareTag ("gravityOut")) {

			Debug.Log("Trigger gravityOut");
			//TriggerX2.SetActive (true);

			rigidb.gravityScale = gravityAwake;
		}
	}


}

