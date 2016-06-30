using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;


public class ChangeInSizeUI : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeShowedTrue(Animator anim)
	{
		anim.SetBool ("showed", true);
	}

	public void changeShowedFalse(Animator anim)
	{
		anim.SetBool ("showed", false);
	}

}
