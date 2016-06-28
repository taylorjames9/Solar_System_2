using UnityEngine;
using System.Collections;

public class ParticleEmissionRate : MonoBehaviour {

	public float particlesEmitted;
	ParticleSystem targetPS;

	// Use this for initialization
	void OnEnable () {
		targetPS = GetComponentInParent<ParticleSystem> ();
	}

	public void setParticleEmissions()
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
