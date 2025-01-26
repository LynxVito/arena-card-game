using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaceCard : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject endTurnButton;
    public SelectCard1 selectCard1;
    public SelectCard2 selectCard2;
    public SelectCard3 selectCard3;
    public bool card1Placed = false;
    public bool card2Placed = false;
    public bool card3Placed = false;
    public GameObject tutorialScreen2;

    public void CardPlacement1() {
        Transform placeCard1 = card1.GetComponent<Transform> ();

        if(selectCard1.cardSelected == true && card1Placed == false) {
            placeCard1.Rotate(-30.0f, 0.0f, 0.0f);
            placeCard1.Translate(-0.03f, 6.286f, 6.188f);
            card1Placed = true;
            endTurnButton.SetActive(true);
            tutorialScreen2.SetActive(false);
        }
    }

        public void CardPlacement2() {
        Transform placeCard2 = card2.GetComponent<Transform> ();

        if(selectCard2.cardSelected == true && card2Placed == false) {
            placeCard2.Rotate(-30.0f, 0.0f, 0.0f);
            placeCard2.Translate(1.683f, 6.276f, 2.668f);
            card2Placed = true;
        }
    }

    public void CardPlacement3() {
        Transform placeCard3 = card3.GetComponent<Transform> ();

        if(selectCard3.cardSelected == true && card3Placed == false) {
            placeCard3.Rotate(-30.0f, 0.0f, 0.0f);
            placeCard3.Translate(1.587f, 6.284f, 3.568f);
            card3Placed = true;
        }
    }
}