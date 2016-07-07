using UnityEngine;
using System.Collections;

public class ParticleEmissionRate : MonoBehaviour {
	[HideInInspector]
	public float particlesEmitted;

	ParticleSystem targetPS;

	// Use this for initialization
	void OnEnable () {
		targetPS = GetComponentInParent<ParticleSystem> ();
	}

	public void increaseEmit(){
		if(particlesEmitted < 1200f)
			particlesEmitted += 300f;
	}

	public void decreaseEmit(){
		if(particlesEmitted > 0f)
			particlesEmitted -= 300f;
	}

	void Update()
	{
		var tempVar = targetPS.emission;
		if (particlesEmitted == 0) {
			tempVar.enabled = false;
		} else {
			tempVar.enabled = true;
			tempVar.rate = new ParticleSystem.MinMaxCurve(particlesEmitted);
		}
	}
}
