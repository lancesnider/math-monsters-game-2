using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

  private GameObject currentObject = null;

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
      currentObject = CheckHit();
      if(currentObject != null) {
        currentObject.SendMessage("HandleMouseDown");
      }
    } else if (Input.GetMouseButtonUp(0)) {
      GameObject checkHit = CheckHit();

      if (currentObject!= null & checkHit == currentObject) {
        currentObject.SendMessage("HandleClick");
      }else if (currentObject!= null) {
        currentObject.SendMessage("HandleReleaseOutside");
      }
      currentObject = null;
    }
	}


  GameObject CheckHit () {
    RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
    if (hit.collider != null) {
      return hit.collider.gameObject;
    }
    return null;
  }
}
