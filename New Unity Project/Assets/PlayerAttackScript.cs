using UnityEngine;
using System.Collections;

public class PlayerAttackScript : MonoBehaviour {

	public float AttackSpeed = 1f;
	public float AttackRange = 1f;

	void Start () {
	
	}

	void Update () {
		GameObject.Find ("Weapon").transform.localPosition = new Vector3 (Mathf.Sin (Time.time*AttackSpeed) * Time.deltaTime * AttackRange, 0f, 0f);
	}
}
