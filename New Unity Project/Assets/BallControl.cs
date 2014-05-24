using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W))
			this.transform.position = this.transform.position + this.transform.forward / 10.0f; 
		if (Input.GetKey (KeyCode.S))
			this.transform.position = this.transform.position - this.transform.forward / 10.0f; 
		if (Input.GetKey (KeyCode.A))
			this.transform.position = this.transform.position - this.transform.right / 10.0f; 
		if (Input.GetKey (KeyCode.D))
			this.transform.position = this.transform.position + this.transform.right / 10.0f; 
			
	}
}
