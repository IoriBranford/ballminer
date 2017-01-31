﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitCollider : MonoBehaviour {
	void OnTriggerEnter2D (Collider2D otherCollider) {
		LevelManager levelManager =
			GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadLevel("Lose");
	}
}
