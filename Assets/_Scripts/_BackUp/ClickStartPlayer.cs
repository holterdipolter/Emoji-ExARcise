using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ClickStartPlayer : MonoBehaviour {

	public GameObject Player;
	public GameObject PlayerStatic;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {

		PlayerStatic.SetActive(false);
		Player.SetActive(true);

	}
}
