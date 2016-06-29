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
		//UIenabled = !UIenabled;
		//Debug.Log(this  + " has detected double tap");
		foreach(GameObject g in GameObject.FindGameObjectsWithTag("Planet"))
		{
			//if(UIenabled)
			g.GetComponent<ToggleUi>().togglePlanetUI();
		}

	}
}
