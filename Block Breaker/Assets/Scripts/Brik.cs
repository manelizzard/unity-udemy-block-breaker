using UnityEngine;
using System.Collections;

public class Brik : MonoBehaviour {

	public int maxHits;

	private int timesHits;

	// Use this for initialization
	void Start () {
		timesHits = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision) {
		timesHits++;

		if (timesHits == maxHits) {
			Destroy (this);
		}
	}
}
