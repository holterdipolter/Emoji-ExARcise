using UnityEngine;
using System.Collections;


public class KaliKreisController : MonoBehaviour {

	public GameObject RefTarget;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		// convert to ScreenSpace
		Vector3 RefTargetScreenSpace = Camera.main.WorldToScreenPoint(RefTarget.transform.position);

//		float RefTargetScreenSpaceNormX = (RefTargetScreenSpace.x - 500) * 0.04f;
//		float RefTargetScreenSpaceNormY = (RefTargetScreenSpace.y - 375) * 0.04f;
//
//		transform.position = new Vector3(RefTargetScreenSpaceNormX,RefTargetScreenSpaceNormY,-3);


		transform.position = new Vector3(RefTargetScreenSpace.x,RefTargetScreenSpace.y,-3);



		print("transform.position: "+ transform.position);

	}
}
