using UnityEngine;
using System.Collections;

public class SinRescaler : MonoBehaviour {

	public float Amplitude;
	public float Speed;

	private float x;
	private float y;
	private float z;


	void Start () {

		x = transform.localScale.x;
		y = transform.localScale.y;
		z = transform.localScale.z;

	}

	void Update () {
		
		transform.localScale = new Vector3 ((x + Amplitude*(Mathf.Sin((Time.deltaTime + Time.frameCount * 0.1f) * Speed))),(y + Amplitude*(Mathf.Sin((Time.deltaTime + Time.frameCount * 0.1f) * Speed))),z);

	}
}
