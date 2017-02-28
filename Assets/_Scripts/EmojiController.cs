using UnityEngine;
using System.Collections;
using DigitalRuby.SoundManagerNamespace;

public class EmojiController : MonoBehaviour {

	public int level;
	public float speed;
	public GameObject text;
	public GameObject naechstesLevel;
	public AudioSoundManager audioman;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Pick Up"))
			other.gameObject.SetActive(false);
			text.SetActive(true);
			naechstesLevel.SetActive(true);
			audioman.PlaySound (1);
			PlayerPrefs.SetInt("level", level);
			Debug.Log("saveLevel " +level);
	}
}

