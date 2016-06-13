using UnityEngine;
using System.Collections;

public class OscillatingSpiralSize : MonoBehaviour {

	int counter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		counter++;
		if (counter % 100 == 0) {
			SprialField spf = GetComponent<SprialField> ();
			spf.size = Mathf.PingPong (Time.time, 3.0f) -1 ;
		}
	
	}
}
