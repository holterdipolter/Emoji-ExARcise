using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDown : MonoBehaviour {

	public float Speed;

	private float x;
	private float y;
	private float z;
	private float xRot;
	private float yRot;
	private float zRot;

	void SetRandomValues(){


	}

	void Start () {

		SetRandomValues();

		x = transform.position.x;
		y = transform.position.y;
		z = transform.position.z;
		xRot = transform.rotation.x;
		yRot = transform.rotation.y;
		zRot = transform.rotation.z;

	}

	void Update () {

		int j;
		for (int i = 0; i <= 5; i++) {
			
		
		}


		transform.position = new Vector3 (x,(y - (Time.deltaTime + Time.frameCount*0.01f)*Speed),z);
		transform.Rotate(new Vector3 (0,0,(Time.deltaTime*Speed*10)));

	}
}