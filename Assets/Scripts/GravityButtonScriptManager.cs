using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TouchScript.Gestures;

public class GravityButtonScriptManager : MonoBehaviour {

	public Button[] gsArray;
	[HideInInspector]public float value;

	// Use this for initialization
	void Awake() {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeGravUI(float buttonPressed)
	{
		GetComponentInParent<ForceField> ().ModifyGravity (buttonPressed);
		if (!GetComponentInParent<ToggleUi> ().turnedOff) {
			for (int i = 0; i < gsArray.Length; i++) {
				if (i < (int)buttonPressed) {
					gsArray [i].GetComponent<Image> ().color = Color.cyan;
				} else {
					gsArray [i].GetComponent<Image> ().color = Color.grey;
				}
			}
		} else {
			for (int i = 0; i < gsArray.Length; i++) {
				if (i < (int) buttonPressed) {
					gsArray [i].GetComponent<Image> ().CrossFadeAlpha(0f, 1f, true);
				} /*else {
					gsArray [i].GetComponent<Image> ().color = Color.grey;
				}*/
			}
		}
		//Debug.Log ("changeGravUI called, button pressed: " + buttonPressed);
	}
}
