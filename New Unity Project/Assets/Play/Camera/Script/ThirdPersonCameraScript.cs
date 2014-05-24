using UnityEngine;
using System.Collections;

public class ThirdPersonCameraScript : MonoBehaviour {

	public GameObject Player = null;
	public float damping = 1f;
	private Vector3 offset;

	void Start () {
		offset = Player.transform.position - new Vector3(2f, 1.5f, 0f);

		float desiredAngle = Player.transform.eulerAngles.y+90f;
		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
		
		transform.position = Player.transform.position - (rotation * offset);
		
		transform.LookAt(Player.transform);
	}

	void Update () {
		float currentAngle = transform.eulerAngles.y + 90f;
		float desiredAngle = Player.transform.eulerAngles.y + 90f;
		float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);

		Quaternion rotation = Quaternion.Euler(0, angle, 0);
		transform.position = Player.transform.position - (rotation * offset);

		transform.LookAt(Player.transform);
	}
}
