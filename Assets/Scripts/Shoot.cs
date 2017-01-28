using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(0, 10, -55, ForceMode.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
