using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropdown : MonoBehaviour
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

    // public void PlayDropDown() {
        
    //     Transform t = gameObject.transform;

    //     if (pressedPlay == true) {
    //         t.Translate (0.0f, 500.0f, 0.0f);
    //     }
    // }
}
