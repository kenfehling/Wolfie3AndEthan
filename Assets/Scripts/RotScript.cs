using UnityEngine;
using System.Collections;

public class RotScript : MonoBehaviour {

	public float rotSpeed = 0.02f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(rotSpeed, 0.0f, 0.0f);
	}
}
