using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayMovieTextureOnUI : MonoBehaviour {

	public RawImage rawimage;

	// Use this for initialization
	void Start () {
	
		WebCamTexture webcamTexture = new WebCamTexture();
		rawimage.texture = webcamTexture;
		rawimage.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
