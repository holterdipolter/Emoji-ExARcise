using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ClickExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {
		Application.Quit();
	}
}
