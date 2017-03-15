using UnityEngine;
using System.Collections;


public class GameObjectController : MonoBehaviour {

	// berechnet und setzt Position bzw. z-Rotation des virtuellen Spiel-Objekts im Spielfeld (Ascii-Zeichen)

	public GameObject TargetTangibleObj;
	public GameObject TargetRefLU;
	public GameObject TargetRefRO;
	public GameObject ImageRefLU;
	public GameObject ImageRefRO;

	private float startRotationZ;

	private Vector3 pos;
	private Vector3 posWS;
	Vector3 angle;
	private float z;


	void Start () {

		// Speichere in Unity gesetzte z-Rotationswerte 
		z = transform.position.z;
		startRotationZ = transform.eulerAngles.z;

	}

	// Update is called once per frame
	void Update () {

		// POSITION IN RELATION ZU KALLIBRIRUNGSMARKER BESTIMMEN:
		// Konveriere Worldspace nach Screenspace
		Vector3 TargetTangibleObjScreenSpace = Camera.main.WorldToScreenPoint(TargetTangibleObj.transform.position);
		Vector3 TargetRefLUScreenSpace = Camera.main.WorldToScreenPoint(TargetRefLU.transform.position);
		Vector3 TargetRefROScreenSpace = Camera.main.WorldToScreenPoint(TargetRefRO.transform.position);

		// Berechne (Distanz TO-refLU) / (Distanz refRO-refLU), -> pos max = 1
		pos.x = (TargetTangibleObjScreenSpace.x - TargetRefLUScreenSpace.x) / (TargetRefROScreenSpace.x - TargetRefLUScreenSpace.x);
		pos.y = (TargetTangibleObjScreenSpace.y - TargetRefLUScreenSpace.y) / (TargetRefROScreenSpace.y - TargetRefLUScreenSpace.y);

		// Konvertiere relative Distanz -> Distanz (Ref-Marker -> Spiel-Marker) im Worldspace
		posWS.x = (pos.x * (ImageRefRO.transform.position.x - ImageRefLU.transform.position.x)) + ImageRefLU.transform.position.x;
		posWS.y = (pos.y * (ImageRefRO.transform.position.y - ImageRefLU.transform.position.y)) + ImageRefLU.transform.position.y;


		// setze finale Position
		transform.position = new Vector3(posWS.x,posWS.y,z);

		//Debug.Log(" qrLU: "+ TargetRefLUScreenSpace + " qrRO: "+ TargetRefROScreenSpace + " TO: "+ TargetTangibleObjScreenSpace + " pos: "+ pos + " RefDistance: " + (ImageRefRO.transform.position.x - ImageRefLU.transform.position.x) + " Heading: " + (Mathf.Rad2Deg*Mathf.Asin(TargetTangibleObj.transform.forward.x)));


		// ROTATION:
		// z-Rotation mit Hilfe des Arcus-Tangenz berechnen
		angle = new Vector3(0,0, Mathf.Atan2(TargetTangibleObj.transform.forward.x, TargetTangibleObj.transform.forward.y) * Mathf.Rad2Deg*(-1));
		transform.eulerAngles = angle;

		//Debug.Log ("TargetTangibleObj.transform.forward: " + TargetTangibleObj.transform.forward + "WinkelZ: " + TargetTangibleObj.transform.forward.y);

	}
}
