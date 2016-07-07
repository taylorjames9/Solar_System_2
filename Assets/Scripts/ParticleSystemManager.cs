using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ParticleSystemManager : MonoBehaviour {
	[HideInInspector]
	public float particlesEmitted;

	ParticleSystem targetPS;
	public Sprite playSprite;
	public Sprite pauseSprite;

	void OnEnable()
	{
		targetPS = GetComponent<ParticleSystem> ();
	}

	public void toggleOnOff(){
		if (!GetComponent<ParticleSystem> ().isPlaying) {
			GameObject.Find ("OnOffButton").GetComponent<Button>().image.sprite = pauseSprite;
			GetComponent<ParticleSystem> ().Play ();
			Debug.Log (GetComponent<ParticleSystem> ().isPlaying);
		} else {
			GameObject.Find ("OnOffButton").GetComponent<Button>().image.sprite = playSprite;
			GetComponent<ParticleSystem> ().Pause ();
			GetComponent<ParticleSystem> ().Clear ();
			Debug.Log (GetComponent<ParticleSystem> ().isPlaying);
		}

	}

	public void increaseEmit(){
		if (particlesEmitted < 1200f) {
			particlesEmitted += 300f;
		}
		Debug.Log ("float particlesEmitted: " + particlesEmitted);
		Debug.Log ("actual emission rate max: " + targetPS.emission.rate.constantMax + ", min: " + targetPS.emission.rate.constantMin);
		//setParticlesE ();
	}

	public void decreaseEmit(){
		if (particlesEmitted > 0f) {
			particlesEmitted -= 300f;
		}
		Debug.Log ("float particlesEmitted: " + particlesEmitted);
		Debug.Log ("actual emission rate max: " + targetPS.emission.rate.constantMax + ", min: " + targetPS.emission.rate.constantMin);
		//setParticlesE ();

	}

	void Update()
	{
		setParticlesE ();
	}

	public void setParticlesE(){
		var tempVar = targetPS.emission;
		if (particlesEmitted == 0) {
			tempVar.enabled = false;
		} else {
			tempVar.enabled = true;
			tempVar.rate = new ParticleSystem.MinMaxCurve(particlesEmitted);
		}
	}

}
