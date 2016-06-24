using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TouchScript.Gestures;
using TouchScript.Behaviors;


public class GravityStrButton : MonoBehaviour {

	public float buttonID;

	// Use this for initialization
	void OnEnable () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void doSomething()
	{
		GetComponentInParent<GravityButtonScriptManager> ().changeGravUI(buttonID);
		//Debug.Log ("dosomething called, button ID: " + buttonID);
	}
}
