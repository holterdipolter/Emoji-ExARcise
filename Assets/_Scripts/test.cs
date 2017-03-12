using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	public GameObject to;

	private Transform startrans;
	private Quaternion startRot;
	private float angle;


	// Use this for initialization
	void Start () {

		//startrans = transform;
		startRot = transform.rotation;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		//Vector3 targetDir = startransVec - transform.position;

		//angle = Quaternion.Angle (startRot, transform.rotation);

		float angle1 = Mathf.Atan2(to.transform.forward.y, to.transform.forward.z) * Mathf.Rad2Deg;
		float angle2 = Mathf.Atan2(to.transform.forward.x, to.transform.forward.z) * Mathf.Rad2Deg;

		float angle3 = Mathf.Asin(transform.forward.z) * Mathf.Rad2Deg;
		float angle4 = Mathf.Asin(transform.forward.x) * Mathf.Rad2Deg;
		float angle5 = Mathf.Asin(transform.forward.y) * Mathf.Rad2Deg;
		float angle6 = Mathf.Asin(transform.forward.z) * Mathf.Rad2Deg;

		//angle = to.transform.forward.x * 90 * (to.transform.forward.z * 0.5 + 1);

		transform.eulerAngles = new Vector3 (0, 0, angle);

		Debug.Log(" 1: " + to.transform.forward + " Angle: x: " + angle1 + " y: " + angle2 + " 3: " + angle3 + " 4: " + angle4 + " 5: " + angle5 + " 6: " +angle6);


	}

}
