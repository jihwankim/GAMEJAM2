using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour {
	private Vector3 direction;
	
	void Start () {
	}

	void Update () {

		direction = new Vector3(0,0,0); 
		Matrix4x4 mValue = new Matrix4x4(); 
		
		mValue = Matrix4x4.identity; 
		mValue.SetTRS(new Vector3(0,0,0),Quaternion.Euler(new Vector3(0f,transform.eulerAngles.y,0f)),new Vector3(1,1,1)); 
		
		direction += mValue.MultiplyVector (new Vector4(0,0,1)); 
		
		direction.Normalize();

		if (Input.GetKey (KeyCode.W)) {
			transform.position += direction * Time.deltaTime * 5;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += -direction * Time.deltaTime * 5;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.RotateAround( transform.position, new Vector3(0f, -1f, 0f), 5f );
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.RotateAround( transform.position, new Vector3(0f, 1f, 0f), 5f );
		}
	}
}
