using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAbility : MonoBehaviour
{
    public int currentlyHolding;
    public GameObject ability1;
    public GameObject knives;
    public GameObject gun;
    public GameObject ability1Selected;
    public GameObject knivesSelected;
    public GameObject gunSelected;

    void Start() {
        currentlyHolding = 0;
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            currentlyHolding = 0;
            ability1.SetActive(true);
            knives.SetActive(true);
            gun.SetActive(false);
            ability1Selected.SetActive(false);
            knivesSelected.SetActive(false);
            gunSelected.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.E)) {
            currentlyHolding = 1;
            ability1.SetActive(false);
            knives.SetActive(true);
            gun.SetActive(true);
            ability1Selected.SetActive(true);
            knivesSelected.SetActive(false);
            gunSelected.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Q)) {
            currentlyHolding = 2;
            ability1.SetActive(true);
            knives.SetActive(false);
            gun.SetActive(true);
            ability1Selected.SetActive(false);
            knivesSelected.SetActive(true);
            gunSelected.SetActive(false);
        }
    }
}
