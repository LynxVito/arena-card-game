using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownOnlineOffline : MonoBehaviour
{
    public bool pressedPlay = false;

    public void PlayIsPressed() {
        if (pressedPlay == false) {
            pressedPlay = true;
        }
        else {
            pressedPlay = false;
        }
    }

    public void PlayDropDown() {
        RectTransform drop = GetComponent<RectTransform> ();

        if(pressedPlay == true) {
            drop.Translate(0.0f, -890.0f, 0.0f);
        }
        else {
            drop.Translate(0.0f, 890.0f, 0.0f);
        }
    }
}
