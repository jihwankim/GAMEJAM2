using UnityEngine;
using System.Collections;

public class ChainCreate : MonoBehaviour {

	public GameObject Chain = null;
	public int ChainCount = 0;

	// Use this for initialization
	void Start () {
		//this.GetComponent<Rigidbody> ().Sleep ();// rigidbody = null;
		if (ChainCount > 0) 
		{
			Vector3 gap =  this.renderer.bounds.size * 0.5f;
			GameObject NextChain = (GameObject)GameObject.Instantiate (Chain, this.transform.position + Vector3.Scale(gap, this.transform.up), this.transform.rotation);// this.transform.up);

			NextChain.GetComponent<ChainCreate> ().ChainCount = ChainCount - 1;

			this.GetComponent<HingeJoint> ().connectedBody = NextChain.GetComponent<Rigidbody>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
