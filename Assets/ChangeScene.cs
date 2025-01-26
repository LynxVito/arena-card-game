using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    /**
* This script is based upon an example from the Unity Script
Reference
*
* Author: Unity Technologies (author name unknown)
* Location: https://docs.unity3d.com/6000.0/Documentation/ScriptReference/WaitForSeconds.html
* Accessed: 23/Jan/2025
*/
    void Start() {
        StartCoroutine(NextScene());
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(16);
        SceneManager.LoadScene("Card game");
    }

}
