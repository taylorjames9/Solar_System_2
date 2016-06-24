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
		tempVar.enabled = true;
		tempVar.rate = new ParticleSystem.MinMaxCurve(particlesEmitted);
	}
}
