using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float speed;


	// Update is called once per frame
	void Update () {
		
		transform.Rotate (new Vector3 (0,(speed * 45 * Time.deltaTime *1.3f),0));	
	}
}
