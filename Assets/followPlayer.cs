using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour {
	public GameObject toFollow;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 toGo = toFollow.transform.position;
		toGo.z = -10;
		gameObject.transform.position = toGo;
	}
}
