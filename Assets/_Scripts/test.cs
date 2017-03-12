using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	public GameObject to;
	public float calibration;

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
		float angle2 = Mathf.Atan2(to.transform.forward.z, to.transform.forward.y) * Mathf.Rad2Deg;
		float angle3 = Mathf.Atan2(to.transform.forward.x, to.transform.forward.z) * Mathf.Rad2Deg;
		float angle4 = Mathf.Atan2(to.transform.forward.z, to.transform.forward.x) * Mathf.Rad2Deg;
		float angle5 = Mathf.Atan2(to.transform.forward.x, to.transform.forward.y) * Mathf.Rad2Deg;
		float angle6 = Mathf.Atan2(to.transform.forward.y, to.transform.forward.x) * Mathf.Rad2Deg;



		//angle = to.transform.forward.x * 90 + (to.transform.forward.x * to.transform.forward.z * calibration);
		angle = to.transform.eulerAngles.z;

		transform.eulerAngles = new Vector3 (0, 0, angle5);

		//Debug.Log(" 1: " + to.transform.forward + " Angle: 1: " + angle1 + " 2: " + angle2 + " 3: " + angle3 + " 4: " + angle4 + " 5: " + angle5 + " 6: " +angle6);
		Debug.Log(" 1: " + to.transform.forward + " 5: " + angle5 + " 6: " +angle6);
		//Debug.Log(" 1: " + to.transform.forward + " AngleZ: " + angle);


	}

}
