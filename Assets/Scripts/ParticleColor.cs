using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ParticleColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Gradient myColorToYellow = new Gradient();
		//myColorToYellow.SetKeys (new GradientColorKey[]{new GradientColorKey(GetComponent<Image>.Color, 1.0f), new GradientColorKey(Color.yellow, 0.5f)}, new GradientAlphaKey[](0.0f, 1.0f)});

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeParticleColor(){
		Debug.Log (this + " pressed, changing PS to " + this.GetComponentInParent<Image> ().color);
		//GetComponentInParent<ParticleSystem>().colorOverLifetime.color = 
	}
}
