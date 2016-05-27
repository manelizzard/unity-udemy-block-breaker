using UnityEngine;
using System.Collections;

public class Brik : MonoBehaviour {

	public int maxHits;

	public Sprite[] hitSprites;

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

	void OnCollisionExit2D(Collision2D collision) {
		timesHits++;

		if (timesHits >= maxHits) {
			Destroy (gameObject);
		} else {
			LoadSprites ();
		}
	}

	void LoadSprites() {
		int spriteIndex = timesHits - 1;
		this.GetComponent<SpriteRenderer> ().sprite = hitSprites [spriteIndex];
	}
}
