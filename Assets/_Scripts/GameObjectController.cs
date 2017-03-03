using UnityEngine;
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


	// Use this for initialization
	void Start () {
		
		offsetpos = transform.position - TargetTangibleObj.transform.position;
	}

	// Update is called once per frame
	void Update () {

		// Kallibrieren:
		// convert Worldspace to Screenspace
		Vector3 TargetTangibleObjScreenSpace = Camera.main.WorldToScreenPoint(TargetTangibleObj.transform.position);
		Vector3 TargetRefLUScreenSpace = Camera.main.WorldToScreenPoint(TargetRefLU.transform.position);
		Vector3 TargetRefROScreenSpace = Camera.main.WorldToScreenPoint(TargetRefRO.transform.position);

		// Compute (distance TO-refLU) / (distance refRO-refLU), -> pos max = 1
		pos.x = (TargetTangibleObjScreenSpace.x - TargetRefLUScreenSpace.x) / (TargetRefROScreenSpace.x - TargetRefLUScreenSpace.x);
		pos.y = (TargetTangibleObjScreenSpace.y - TargetRefLUScreenSpace.y) / (TargetRefROScreenSpace.y - TargetRefLUScreenSpace.y);

		// Convert relative distance to distance in Worldspace
		posWS.x = (pos.x * (ImageRefRO.transform.position.x - ImageRefLU.transform.position.x)) + ImageRefLU.transform.position.x + offsetX;
		posWS.y = (pos.y * (ImageRefRO.transform.position.y - ImageRefLU.transform.position.y)) + ImageRefLU.transform.position.y + offsetY;

		//posWS.x = (pos.x * 31.27f) - 15.47f;
		//posWS.y = (pos.y * 21.5f) - 10.7f;

		transform.position = new Vector3(posWS.x,posWS.y,-0.5f);

		//print(" qrLU: "+ TargetRefLUScreenSpace + " qrRO: "+ TargetRefROScreenSpace + " TO: "+ TargetTangibleObjScreenSpace + " pos: "+ pos + " RefDistance: " + (ImageRefRO.transform.position.x - ImageRefLU.transform.position.x) + " Heading: " + (Mathf.Rad2Deg*Mathf.Asin(TargetTangibleObj.transform.forward.x)));


		// Rotation:

		transform.eulerAngles = new Vector3 (0,0,(Mathf.Rad2Deg * Mathf.Asin(TargetTangibleObj.transform.forward.x) +90));

		//transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.identity, speed * Time.deltaTime);
		//'speed' is a variable you define or a constant you insert and is measured in degrees per second.
		//If you want an eased rotation, change 'RotateTowards' to 'Slerp' and adjust the 'speed' downward a bunch.

		//print ("Heading: " + transform.forward.x * Mathf.Rad2Deg);
	}
}
