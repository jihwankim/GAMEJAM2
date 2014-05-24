using UnityEngine;
using System.Collections;

public class PlayerAttackScript : MonoBehaviour {

	public float AttackSpeed = 1f;
	public float AttackRange = 1f;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Body")
		{
			print (" BODY IN " + Time.time.ToString());
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Body")
		{
			print (" BODY OUT " + Time.time.ToString());
		}
	}

	void Start () {
	
	}

	void Update () {
		transform.FindChild ("Weapon").transform.localPosition = new Vector3 (Mathf.Sin (Time.time*AttackSpeed) * Time.deltaTime * AttackRange, 0f, 0f);

		GameObject [] BodyList = GameObject.FindGameObjectsWithTag ("Body");
		for(int i = 0; i < BodyList.Length; ++i)
		{
			//if(this.rigidbody.
		}
	}
}
