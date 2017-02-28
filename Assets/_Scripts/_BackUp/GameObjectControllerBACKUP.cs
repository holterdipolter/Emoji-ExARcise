using UnityEngine;
using System.Collections;


public class GameObjectControllerBACKUP : MonoBehaviour {

	public GameObject qrTangibleObj;
	public GameObject qrRef;
	public Vector3 adjustTangibleObj;
	public float zFactor;

	private Vector3 offsetpos;
	//private float offsetrot=298;
	private float offsetrot;
	private Vector3 pos;
	//private float x;
	//private float y;
	//private float z;



	// Use this for initialization
	void Start () {
		
		offsetpos = transform.position - qrTangibleObj.transform.position;
	}

	// Update is called once per frame
	void Update () {
		
		pos = (qrTangibleObj.transform.position - qrRef.transform.position + adjustTangibleObj)/(qrRef.transform.position.z / zFactor);

		transform.position = new Vector3(pos.x,pos.y,3);

		print(transform.position +"z-wert von ref ist "+ qrRef.transform.position.z + "z-wert von to ist "+ qrTangibleObj.transform.position.z);

		// ROTATION
		//transform.rotation = Quaternion.AngleAxis((target1.transform.rotation.eulerAngles.x-offsetrot), Vector3.forward);
		//print(target1.transform.rotation.eulerAngles);

	}
}
