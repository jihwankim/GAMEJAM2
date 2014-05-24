using UnityEngine;
using System.Collections;

public class ThirdPersonCameraScript : MonoBehaviour {

	public GameObject Player = null;
	private Vector3 offset;

	void Start () {
		offset = Player.transform.position - new Vector3(2f, 1.5f, 0f);
	}

	void Update () {
		float desiredAngle = Player.transform.eulerAngles.y+90f;
		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

		transform.position = Player.transform.position - (rotation * offset);

		transform.LookAt(Player.transform);
	}
}
