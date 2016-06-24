using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ThDEmitControl : MonoBehaviour {


	void OnEnable()
	{
	}
	
	// Update is called once per frame
	void Update () {
		GetComponentInParent<ParticleSystem>().shape.randomDirection.Equals(this.GetComponent<Toggle> ().isOn);
		Debug.Log ("found particle system " + GetComponentInParent<ParticleSystem>());
	}
}
