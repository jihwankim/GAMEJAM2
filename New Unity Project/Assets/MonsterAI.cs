using UnityEngine;
using System.Collections;

public class MonsterAI : MonoBehaviour {

	Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find ("Player");
		float distance = Vector3.Distance (player.transform.position, this.transform.position);

		// RAGE
		if (distance < 3.0f) 
		{
			// Attack
			if (distance < 0.5f) 
			{

			}else
			{
				this.transform.position -= (this.transform.position - player.transform.position) * Time.deltaTime / 5;
			}
		} 
		else // BACK  
		{
			this.transform.position -= (this.transform.position - startPos) * Time.deltaTime;
		}

	}
}
