using UnityEngine;
using System.Collections;

public class SinMover : MonoBehaviour {

	public float AmplitudeX;
	public float AmplitudeY;
	public float Speed;

	private float x;
	private float y;
	private float z;


	void Start () {

		x = transform.localPosition.x;
		y = transform.localPosition.y;
		z = transform.localPosition.z;

	}

	void Update () {
		
		transform.localPosition = new Vector3 ((x + AmplitudeX*(Mathf.Sin((Time.deltaTime + Time.frameCount*0.1f)*Speed))),(y + AmplitudeY*(Mathf.Sin((Time.deltaTime + Time.frameCount*0.1f)*Speed))),z);

	}
}
