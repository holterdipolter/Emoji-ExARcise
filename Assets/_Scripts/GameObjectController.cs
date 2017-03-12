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

	private float startRotationZ;
	private Vector3 offsetpos;

	private Vector3 pos;
	private Vector3 posWS;
	Vector3 angle;
	private float z;


	// Use this for initialization
	void Start () {
		
		offsetpos = transform.position - TargetTangibleObj.transform.position;
		z = transform.position.z;
		startRotationZ = transform.eulerAngles.z;


	}

	// Update is called once per frame
	void Update () {

		// POSITION IN RELATION ZU KALLIBRIRUNGSMARKER BESTIMMEN:
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


		// set final position
		transform.position = new Vector3(posWS.x,posWS.y,z);

		//Debug.Log(" qrLU: "+ TargetRefLUScreenSpace + " qrRO: "+ TargetRefROScreenSpace + " TO: "+ TargetTangibleObjScreenSpace + " pos: "+ pos + " RefDistance: " + (ImageRefRO.transform.position.x - ImageRefLU.transform.position.x) + " Heading: " + (Mathf.Rad2Deg*Mathf.Asin(TargetTangibleObj.transform.forward.x)));


		// ROTATION:


		angle = new Vector3(0,0, Mathf.Atan2(TargetTangibleObj.transform.forward.x, TargetTangibleObj.transform.forward.y) * Mathf.Rad2Deg*(-1));
		transform.eulerAngles = angle;

		//Debug.Log ("TargetTangibleObj.transform.forward: " + TargetTangibleObj.transform.forward + "WinkelZ: " + TargetTangibleObj.transform.forward.y);

	}
}
