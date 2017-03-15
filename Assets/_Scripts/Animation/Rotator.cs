using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float speed;

	// konstante Bewegung um y-Achse

	void Update () {
		
		transform.Rotate (new Vector3 (0,(speed * 45 * Time.deltaTime *1.3f),0));	
	}
}
