using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime*5);
        gameObject.transform.Translate(Input.GetAxis("Vertical") * Vector3.up * Time.deltaTime*5);
	}
}
