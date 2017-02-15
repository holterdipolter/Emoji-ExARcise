using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ClickCaliFertig : MonoBehaviour {

	//set off at click
	public GameObject BackgroundPlane;
	public GameObject Startscreen;
	public GameObject CaliFertig;
	public GameObject KaliKreisTOchild;
	public GameObject Player;
	public GameObject TextGewonnen;
	public GameObject naechstesLevel;

	//set on at click
	public GameObject Game;


	// Use this for initialization
	void Start () {

		Player.SetActive(false);
		TextGewonnen.SetActive(false);
		naechstesLevel.SetActive(false);

		BackgroundPlane.SetActive(true);
		Startscreen.SetActive(true);
		CaliFertig.SetActive(true);
		KaliKreisTOchild.SetActive(true);

		Game.SetActive(false);

	}

	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {

		BackgroundPlane.SetActive(false);
		Startscreen.SetActive(false);
		CaliFertig.SetActive(false);
		KaliKreisTOchild.SetActive(false);

		Game.SetActive(true);

		Player.SetActive(false);
		TextGewonnen.SetActive(false);
		naechstesLevel.SetActive(false);

	}
}
