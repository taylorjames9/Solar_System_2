using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleGravityndSprite : MonoBehaviour {

	public Sprite pullImg;
	public Sprite pushImg;
	bool pulling = true;

	// Use this for initialization
	void Update () {
		if (pulling) {
			GetComponent<Image> ().sprite = pullImg;
		} else {
			GetComponent<Image> ().sprite = pushImg;
		}
	}

	// Update is called once per frame
	public void GandSswap()
	{
		GetComponentInParent<ForceField> ().toggleRepulse ();
		pulling = !pulling;
		Debug.Log ("GandSswap has been called (ToggleGravityndSprite.cs)");
	}
}
