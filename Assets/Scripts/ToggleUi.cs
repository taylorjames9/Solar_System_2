using UnityEngine;
using TouchScript.Behaviors;
using TouchScript.Gestures;
using UnityEngine.UI;
using System;
using System.Collections;

public class ToggleUi : MonoBehaviour {

	public bool turnedOff = false;

	public Toggle tog1;
	public Toggle tog2;

	public Button button1;
	public Button button2;
	public Button button3;
	public Button button4;
	public Button button5;

	public Button nEbutton;
	public Button lEbutton;
	public Button mEbutton;
	public Button hEbutton;

	public Button lSbutton;
	public Button mSbutton;
	public Button sSbutton;

	public Button clearButton;
	public Button emitButton;

	// Use this for initialization
	/*void OnEnable()
	{
		GetComponent<LongPressGesture> ().LongPressed += togglePlanetUI;	
	}

	void OnDisable()
	{
		GetComponent<LongPressGesture> ().LongPressed += togglePlanetUI;
	}*/

	public void togglePlanetUI()//object sender, EventArgs e)
	{
		/*if (GetComponentInChildren<Canvas> ().enabled) {
			GetComponentInChildren<Canvas> ().enabled = false;	
		} else {
			GetComponentInChildren<Canvas> ().enabled = true;
		}*/
		turnedOff = !turnedOff;
		StopAllCoroutines ();
		//Debug.Log (this + " has been long pressed. turnedOff status: " + turnedOff);
		if (GetComponentInChildren<Image> ()) 
		{
				if (turnedOff) {
					StartCoroutine (fadeOutCor ());
				} else {
					StartCoroutine (fadeInCor ());
				}
		}
	}

	IEnumerator fadeOutCor()
	{
		GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(tog1 != null) tog1.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(tog2 != null) tog2.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);	

		if(button1 != null) button1.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(button2 != null) button2.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(button3 != null) button3.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(button4 != null) button4.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(button5 != null) button5.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);

		if(nEbutton != null) nEbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(lEbutton != null) lEbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(mEbutton != null) mEbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(hEbutton != null) hEbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);

		if(lSbutton != null) lSbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(mSbutton != null) mSbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(sSbutton != null) sSbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);

		if(clearButton != null) clearButton.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);
		if(emitButton != null) emitButton.GetComponentInChildren<Image> ().CrossFadeAlpha (0f, 1f, true);

		yield return new WaitForSeconds (.75f);
		GetComponentInChildren<Canvas> ().enabled = false;
	}

	IEnumerator fadeInCor()
	{
		GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(tog1 != null) tog1.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(tog2 != null) tog2.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);	

		if(button1 != null) button1.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(button2 != null) button2.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(button3 != null) button3.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(button4 != null) button4.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(button5 != null) button5.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);

		if(nEbutton != null) nEbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(lEbutton != null) lEbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(mEbutton != null) mEbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(hEbutton != null) hEbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);

		if(lSbutton != null) lSbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(mSbutton != null) mSbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(sSbutton != null) sSbutton.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);

		if(clearButton != null) clearButton.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);
		if(emitButton != null) emitButton.GetComponentInChildren<Image> ().CrossFadeAlpha (1f, 1f, true);

		yield return null;
		GetComponentInChildren<Canvas> ().enabled = true;
	}


}
