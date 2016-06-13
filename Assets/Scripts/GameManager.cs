using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using TouchScript.Behaviors;
using TouchScript.Gestures;

public class GameManager : MonoBehaviour {

	public List<GameObject> reticles;


	void OnEnable(){
		GetComponent<PressGesture> ().Pressed += ReticleAppear;
		GetComponent<ReleaseGesture> ().Released += ReticleDisappear;

	}

	void OnDisable(){
		GetComponent<PressGesture> ().Pressed -= ReticleAppear;
		GetComponent<ReleaseGesture> ().Released -= ReticleDisappear;

	}


	void ReticleAppear(object sender, EventArgs e){
		Debug.Log ("Press gesture");
		reticles [UnityEngine.Random.Range (0, reticles.Count)].SetActive (false);
		reticles [UnityEngine.Random.Range (0, reticles.Count)].transform.position = new Vector3 (GetComponent<PressGesture> ().ScreenPosition.x, GetComponent<PressGesture> ().ScreenPosition.y, -6.0f);
	}

	void ReticleDisappear(object sender, EventArgs e){
		//reticles [UnityEngine.Random.Range (0, reticles.Count)].transform.position = new Vector3 (GetComponent<PressGesture> ().ScreenPosition.x, GetComponent<PressGesture> ().ScreenPosition.y, -6.0f);

	}



}
