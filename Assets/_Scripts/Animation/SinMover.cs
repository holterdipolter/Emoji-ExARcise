using UnityEngine;
using System.Collections;

public class SinMover : MonoBehaviour {

	// führt eine koninuierliche Bewegung um einen Null-Punkt aus
	// nutzt Sinus-Funktion um Bewegung abzurunden

	public float AmplitudeX;
	public float AmplitudeY;
	public float Speed;

	private Vector3 pos;

	private float i = 0;


	void Start () {

		// In Unity eingestellte Positon speichern
		pos = transform.localPosition;

	}

	void Update () {

		// Bewegung gemaess eingestelltem Amplitude X/Y-Wert und Speed-Wert durchfuhren
		i = i + 5 * Speed * Time.deltaTime;
		transform.localPosition = new Vector3 ((pos.x + AmplitudeX*Mathf.Sin(i)),(pos.y + AmplitudeY*Mathf.Sin(i)),pos.z);
		if (i>=360){ i = 0;};
	
	}
}
