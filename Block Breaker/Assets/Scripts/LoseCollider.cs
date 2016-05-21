using UnityEngine;
using System.Collections;

/// <summary>
/// Collider script to catch the Game Over trigger
/// </summary>
public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D trigger) {
		levelManager.LoadLevel ("Win");
	}
}
