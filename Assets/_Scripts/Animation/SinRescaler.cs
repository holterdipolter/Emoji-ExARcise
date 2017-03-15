using UnityEngine;
using System.Collections;

public class SinRescaler : MonoBehaviour {

	// führt eine koninuierliche Skalierung um einen Null-Punkt aus
	// nutzt Sinus-Funktion um Skalierung abzurunden

	public float Amplitude;
	public float Speed;

	private Vector3 scale;

	private float i = 0;


	void Start () {

		// In Unity eingestellte Skalierung speichern
		scale = transform.localScale;

	}

	void Update () {
		
		// Skalierung gemaess eingestelltem Amplitude-Wert und Speed-Wert durchfuhren
		i = i + 5 * Speed * Time.deltaTime;
		transform.localScale = new Vector3 ((scale.x + Amplitude*Mathf.Sin(i)),(scale.y + Amplitude*Mathf.Sin(i)),scale.z);
		if (i>=360){ i = 0;};
	}
}
