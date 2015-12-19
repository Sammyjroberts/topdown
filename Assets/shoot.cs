using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public GameObject toShoot;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(toShoot, gameObject.transform.position, GetComponentInParent<Transform>().rotation);
		}
	}
}
