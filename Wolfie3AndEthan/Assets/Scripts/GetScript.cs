using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GetScript : MonoBehaviour {

	public Text victoryMessage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		victoryMessage.text = "Win.";
	}
}
