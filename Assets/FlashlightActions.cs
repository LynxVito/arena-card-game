using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashlightActions : MonoBehaviour
{
    public bool flashlightOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Light light = GetComponent<Light> ();
        
        if (light.intensity == 0) {
            if (Input.GetKeyDown (KeyCode.F)) {
                light.intensity = 4;
            }
        }
        else {
            if (Input.GetKeyDown (KeyCode.F)) {
                light.intensity = 0;
            }
        }
    }
}
