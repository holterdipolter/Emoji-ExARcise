using UnityEngine;
using System.Collections;

public class SinRescaler : MonoBehaviour {

	public float Amplitude;
	public float Speed;

	private Vector3 scale;

	private float i = 0;


	void Start () {

		scale = transform.localScale;

	}

	void Update () {

		i = i + 5 * Speed * Time.deltaTime;

		transform.localScale = new Vector3 ((scale.x + Amplitude*Mathf.Sin(i)),(scale.y + Amplitude*Mathf.Sin(i)),scale.z);

		if (i>=360){ i = 0;};
	}
}
