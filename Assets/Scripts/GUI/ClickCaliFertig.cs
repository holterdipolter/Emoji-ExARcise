using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ClickCaliFertig : MonoBehaviour {

	public GameObject Spielbrett;
	public GameObject BackgroundPlane;
	public GameObject CaliFertig;
	public GameObject Restart;

	public GameObject RefLUanim;
	public GameObject RefROanim;
	public GameObject RefLUbig;
	public GameObject RefRObig;
	public GameObject RefTObig;


	public GameObject KaliKreisTOchild;

	// Use this for initialization
	void Start () {

		Spielbrett.SetActive(false);
		BackgroundPlane.SetActive(true);
		Restart.SetActive(false);

		RefLUbig.SetActive(true);
		RefRObig.SetActive(true);
		RefTObig.SetActive(true);
		RefLUanim.SetActive(false);
		RefROanim.SetActive(false);

		KaliKreisTOchild.SetActive(true);

	}

	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {
		Spielbrett.SetActive(true);
		BackgroundPlane.SetActive(false);
		CaliFertig.SetActive(false);
		Restart.SetActive(true);

		RefLUbig.SetActive(false);
		RefRObig.SetActive(false);
		RefTObig.SetActive(false);
		RefLUanim.SetActive(true);
		RefROanim.SetActive(true);

		KaliKreisTOchild.SetActive(false);

	}
}
