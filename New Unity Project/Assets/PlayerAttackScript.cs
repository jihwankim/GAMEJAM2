using UnityEngine;
using System.Collections;

public class PlayerAttackScript : MonoBehaviour {

	public float AttackSpeed = 1f;

	void Start () {
	
	}

	void Update () {
		GameObject.Find ("Weapon").transform.position = new Vector3 (Mathf.Sin (Time.time*AttackSpeed) * Time.deltaTime, 0f, 0f);
	}
}
