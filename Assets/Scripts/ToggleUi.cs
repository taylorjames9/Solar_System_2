using UnityEngine;
using TouchScript.Behaviors;
using TouchScript.Gestures;
using UnityEngine.UI;
using System;

public class ToggleUi : MonoBehaviour {

	// Use this for initialization
	void OnEnable()
	{
		GetComponent<LongPressGesture> ().LongPressed += togglePlanetUI;	
	}

	void OnDisable()
	{
		GetComponent<LongPressGesture> ().LongPressed += togglePlanetUI;
	}

	void togglePlanetUI(object sender, EventArgs e)
	{
		if (GetComponentInChildren<Canvas> ().enabled) {
			GetComponentInChildren<Canvas> ().enabled = false;	
		} else {
			GetComponentInChildren<Canvas> ().enabled = true;
		}
		//Debug.Log (this + " has been pressed");
	}
}
