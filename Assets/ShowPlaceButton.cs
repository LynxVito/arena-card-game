using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPlaceButton : MonoBehaviour
{

    public GameObject setButtonActive;

    void Start()
    {
        setButtonActive.SetActive(false);
    }

    public void CheckIfActive() {

    }
}
