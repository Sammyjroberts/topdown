using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {
	Rigidbody2D rb;
	public float speed = 25;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D>();
		rb.velocity = transform.up*speed;

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (rb.velocity);
	}
}
