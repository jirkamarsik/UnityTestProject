using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobbing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0, 5 * (float) System.Math.Sin(Time.time), 0);
	}
}
