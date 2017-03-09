﻿using UnityEngine;
using System.Collections;


public class GameObjectController : MonoBehaviour {

	public GameObject TargetTangibleObj;
	public GameObject TargetRefLU;
	public GameObject TargetRefRO;
	public GameObject ImageRefLU;
	public GameObject ImageRefRO;

	public float offsetX;
	public float offsetY;

	private Vector3 offsetpos;
	//private float offsetrot=298;
	private float offsetrot;
	private Vector3 pos;
	private Vector3 posWS;
	private float z;


	// Use this for initialization
	void Start () {
		
		offsetpos = transform.position - TargetTangibleObj.transform.position;
		z = transform.position.z;
	}

	// Update is called once per frame
	void Update () {

		// Kallibrieren:
		// Convert Worldspace to Screenspace
		Vector3 TargetTangibleObjScreenSpace = Camera.main.WorldToScreenPoint(TargetTangibleObj.transform.position);
		Vector3 TargetRefLUScreenSpace = Camera.main.WorldToScreenPoint(TargetRefLU.transform.position);
		Vector3 TargetRefROScreenSpace = Camera.main.WorldToScreenPoint(TargetRefRO.transform.position);

		// Compute (distance TO-refLU) / (distance refRO-refLU), -> pos max = 1
		pos.x = (TargetTangibleObjScreenSpace.x - TargetRefLUScreenSpace.x) / (TargetRefROScreenSpace.x - TargetRefLUScreenSpace.x);
		pos.y = (TargetTangibleObjScreenSpace.y - TargetRefLUScreenSpace.y) / (TargetRefROScreenSpace.y - TargetRefLUScreenSpace.y);

		// Convert relative distance to distance in Worldspace
		posWS.x = (pos.x * (ImageRefRO.transform.position.x - ImageRefLU.transform.position.x)) + ImageRefLU.transform.position.x + offsetX;
		posWS.y = (pos.y * (ImageRefRO.transform.position.y - ImageRefLU.transform.position.y)) + ImageRefLU.transform.position.y + offsetY;

		transform.position = new Vector3(posWS.x,posWS.y,z);

		//Debug.Log(" qrLU: "+ TargetRefLUScreenSpace + " qrRO: "+ TargetRefROScreenSpace + " TO: "+ TargetTangibleObjScreenSpace + " pos: "+ pos + " RefDistance: " + (ImageRefRO.transform.position.x - ImageRefLU.transform.position.x) + " Heading: " + (Mathf.Rad2Deg*Mathf.Asin(TargetTangibleObj.transform.forward.x)));


		// Rotation:

		//transform.Rotate (0,0,TargetTangibleObj.transform.forward.x);
		//transform.RotateAround (0,0,TargetTangibleObj.transform.forward.x);
		transform.eulerAngles = new Vector3 (0,0,(Mathf.Rad2Deg * Mathf.Asin(TargetTangibleObj.transform.forward.x) +90));
		//Debug.Log (TargetTangibleObj.transform.forward.x);

		//transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.identity, speed * Time.deltaTime);
		//'speed' is a variable you define or a constant you insert and is measured in degrees per second.
		//If you want an eased rotation, change 'RotateTowards' to 'Slerp' and adjust the 'speed' downward a bunch.

		//Debug.Log("Heading: " + transform.forward.x * Mathf.Rad2Deg);
	}
}