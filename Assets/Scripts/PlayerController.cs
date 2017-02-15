using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public GameObject text;
	public GameObject naechstesLevel;

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
		
	}
}

