using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDrag : MonoBehaviour {

  public bool isDraggable = true;

  public void HandleMouseDown () {
    Debug.Log("Mouse down");
  }

  public void HandleClick () {
    Debug.Log("Clicked");
  }

  public void HandleReleaseOutside () {
    Debug.Log("Released Outside");
  }
}
