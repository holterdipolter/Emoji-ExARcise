using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gewonnen : MonoBehaviour {

	public GameObject StartObject;
	public float anzahlFrames;

	private Vector3 startPosition;
	private Vector3 startScale;

	private Vector3 postitionStep;
	private Vector3 postitionDiff;
	private Vector3 scaleStep;

	private Vector3 UpdateScale;
	private bool stopAni = false;

	private int i=0;


	// Use this for initialization
	void Start () {

		startPosition = transform.position;
		startScale = transform.localScale;

		transform.position = StartObject.transform.position;
		transform.localScale = new Vector3 (0,0,1);

		postitionDiff = startPosition - StartObject.transform.position;
		postitionStep = postitionDiff/(anzahlFrames);

		scaleStep = (startScale - new Vector3 (0,0,1))/(anzahlFrames);

	}
	
	// Update is called once per frame
	void Update () {
		
		if (stopAni == false) {
			
			Debug.Log("stepnr: " + i++);
			Debug.Log("posStartObject.transform.position: " + StartObject.transform.position);
			Debug.Log("startPosition: " + startPosition);
			Debug.Log("postition Differenz: " + postitionDiff);
			Debug.Log("postitionStep: " + postitionStep);

			transform.Translate (postitionStep);



			UpdateScale = transform.localScale + scaleStep;
			transform.localScale = UpdateScale;
		
			if (transform.position == startPosition){
				stopAni = true;
			}
		
		}
		
	}
}
