using UnityEngine;
using System.Collections;

public class playerMover : MonoBehaviour {
	Vector3 mousePos;
	Transform target;
	Vector3 objectPos;
	float angle;
	public float speed = 10;
	// Use this for initialization
	void Start () {
		target = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		mousePos = Input.mousePosition;
		mousePos.z = -10; //The distance between the camera and object
		objectPos = Camera.main.WorldToScreenPoint(target.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
		Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		gameObject.GetComponent<Rigidbody2D>().AddForce(move*speed);
	}
}
