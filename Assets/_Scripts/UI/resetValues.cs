using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetValues : MonoBehaviour {

	Vector3 pos;
	Quaternion rota;
	private Rigidbody2D rigidb;
	private float gravityAwake;

	public void SaveValues () {

		pos = transform.position;
		rota = transform.rotation;

		rigidb = GetComponent<Rigidbody2D>();
		gravityAwake = rigidb.gravityScale;

	}

	public void Reset () {

		transform.position = pos;
		transform.rotation = rota;
		rigidb.gravityScale = gravityAwake;
	}
}

