using UnityEngine;
using System.Collections;

public class PlayerAttackScript : MonoBehaviour {

	public float AttackSpeed = 1f;
	public float AttackRange = 1f;
	bool isPlayerKnockback = false;
	bool isEnemyKnockback = false;
	Vector3 KnockbackDir;
	Collider enemy;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Body")
		{
			enemy = other;
			isEnemyKnockback = true;
			KnockbackDir = 1f * Vector3.Normalize(other.transform.position - this.transform.position);
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Body")
		{
			//print (" BODY OUT " + Time.time.ToString());
		}
	}

	void Start () {
	
	}

	int knockCount = 0;
	void Update () {
		if (isPlayerKnockback || isEnemyKnockback) 
		{
			if (isEnemyKnockback) enemy.transform.position += KnockbackDir * Time.deltaTime * 10;
			if (isPlayerKnockback) this.transform.position -= KnockbackDir * Time.deltaTime * 10;
			knockCount++;
			if (knockCount > 5) {
				knockCount = 0;
				isPlayerKnockback = false;
				isEnemyKnockback = false;
			}
		}
		transform.FindChild ("Weapon").transform.localPosition = new Vector3 (Mathf.Sin (Time.time*AttackSpeed) * Time.deltaTime * AttackRange, 0f, 0f);

		GameObject [] BodyList = GameObject.FindGameObjectsWithTag ("Body");
		for(int i = 0; i < BodyList.Length; ++i)
		{
			//if(this.rigidbody.
		}
	}
}
