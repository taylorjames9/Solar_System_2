using UnityEngine;
using TouchScript.Gestures;
using System.Collections;
using System;

public class ScreenUIToggle : MonoBehaviour {

	bool UIenabled = true;

	// Use this for initialization
	void OnEnable()
	{
		GetComponent<TapGesture>().Tapped += OnDoubleTap;
	}
	
	void OnDisable()
	{
		GetComponent<TapGesture>().Tapped -= OnDoubleTap;
	}
	
	void OnDoubleTap(object sender, EventArgs e)
	{
		foreach(GameObject g in GameObject.FindGameObjectsWithTag("Planet"))
		{
			g.GetComponent<ToggleUi>().togglePlanetUI();
		}

	}
}
