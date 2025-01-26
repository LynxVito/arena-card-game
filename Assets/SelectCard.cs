using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class SelectCard1 : MonoBehaviour
{
    public bool cardSelected = false;
    public int whichCardSelected = 0;
    public PlaceCard placeCard;
    public PlaceOpponentCards endTurn;
    public GameObject placeButton;
    public SelectCard2 selectCard2;
    public SelectCard3 selectCard3;
    public Animator cardAnimator;

    void OnMouseDown() {
        whichCardSelected = 1;
        SelectCard();
        CheckIfActive();
    }

    void SelectCard() {

        Transform selectCard3 = GetComponent<Transform> ();

        if(endTurn.endTheTurn == false) {
            if(whichCardSelected == 1) {
                if(placeCard.card3Placed == false) {
                    if(cardSelected == false) {
                       selectCard3.Translate(0.0f, 0.0f, 0.9f);
                        cardSelected = true;
                    }
                    else {
                        selectCard3.Translate(0.0f, 0.0f, -0.9f);
                        cardSelected = false;
                    }
                }
            }
        }
    }

    public void CheckIfActive() {
        if(endTurn.endTheTurn == false) {
            if(cardSelected == false && selectCard2.cardSelected == false && selectCard3.cardSelected == false) {
                placeButton.SetActive(false);
            }
            else {
                placeButton.SetActive(true);
            }
        }  
    }
}