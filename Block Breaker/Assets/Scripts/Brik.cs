using UnityEngine;
using System.Collections;

public class Brik : MonoBehaviour {

	public int maxHits;

	private int timesHits;

	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		timesHits = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision) {
		timesHits++;

		if (timesHits >= maxHits) {
			Destroy (gameObject);

			if (GameObject.Find("Brik") == null) {
				levelManager.LoadNextLevel ();
			}
		}
	}
}
