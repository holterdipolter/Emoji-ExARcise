using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noGo : MonoBehaviour {

	public GameObject noGoArea;

	private Vector2 posWS;
	private SpriteRenderer sprite;
	private Color startColor;

	// Use this for initialization
	void Start () {

		sprite = GetComponent<SpriteRenderer>();
		startColor = sprite.color;


	}
	
	// Update is called once per frame
	void Update () {

		posWS = new Vector2 (transform.position.x, transform.position.y);

		Debug.Log ("x: " + posWS.x + " y: " + posWS.y + " nogox: " + (noGoArea.transform.position.x - noGoArea.transform.localScale.x/2) + " - " + (noGoArea.transform.position.x + noGoArea.transform.localScale.x/2));

		// check nogo-Area:
					
		if (posWS.x < (noGoArea.transform.position.x - noGoArea.transform.lossyScale.x / 2) || posWS.x > (noGoArea.transform.position.x + noGoArea.transform.lossyScale.x / 2)) {
			Debug.Log ("check1");

			if (posWS.y < (noGoArea.transform.position.y - noGoArea.transform.lossyScale.y / 2) || posWS.y > (noGoArea.transform.position.y + noGoArea.transform.lossyScale.y / 2)) {
				Debug.Log ("check2");

				sprite.color = startColor;


			}
		} else {
			sprite.color = Color.cyan;
		}
		
	}
}
