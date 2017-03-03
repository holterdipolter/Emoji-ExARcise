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

		x = transform.position.x;
		y = transform.position.y;
		z = transform.position.z;

	}

	void Update () {
		
		transform.localPosition = new Vector3 ((x + AmplitudeX*(Mathf.Sin((Time.deltaTime + Time.frameCount*0.1f)*Speed))),(y + AmplitudeY*(Mathf.Sin((Time.deltaTime + Time.frameCount*0.1f)*Speed))),z);

	}
}
