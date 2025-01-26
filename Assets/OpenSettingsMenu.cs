using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettingsMenu : MonoBehaviour
{

    public GameObject settingsMenu;
    public void OpenMenu() {
        settingsMenu.SetActive(true);
    }

    public void CloseMenu() {
        settingsMenu.SetActive(false);
    }
}
