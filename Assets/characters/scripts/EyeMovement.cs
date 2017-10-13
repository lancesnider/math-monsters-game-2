using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeMovement : MonoBehaviour {

  // If your finger is down, all eyes stare at your finger
  // Otherwise, the eyes look around randomly

  public GameObject eyeball;
  Transform eyeballTransform;
  public float distance = 0.4f;
  public bool isDragging = false;

  private Vector2 startingPosition;

	void Start () {
    eyeballTransform = eyeball.transform;
    startingPosition = eyeballTransform.position;
	}

  void Idle () {

  }

  void Staring () {
    // When the cursor is down, stare at it
    if (!isDragging) {

    }
  }

  void Terrified () {
    // When it's being dragged, it's eyes dart downward
  }
}
