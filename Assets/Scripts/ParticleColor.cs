using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ParticleColor : MonoBehaviour {

	Gradient myColorToYellow = new Gradient();
	ParticleSystem targetPS;

	// Use this for initialization
	void OnEnable() {
		targetPS = GetComponentInParent<ParticleSystem>();
		myColorToYellow.SetKeys(new GradientColorKey[]{new GradientColorKey(GetComponent<Image>().color, 0.0f), new GradientColorKey(Color.yellow, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) } );
	}

	public void changeParticleColor(){
		//Debug.Log (this + " pressed, changing PS to " + this.GetComponentInParent<Image> ().color);
		var tempVar = targetPS.colorOverLifetime;
		tempVar.enabled = true;
		tempVar.color = new ParticleSystem.MinMaxGradient(myColorToYellow);
	}
}
