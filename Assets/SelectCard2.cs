using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectCard2 : MonoBehaviour
{
    public SelectCard1 isCard1Selected;
    public PlaceCard placeCard;
    public PlaceOpponentCards endTurn;
    public GameObject placeButton;
    public SelectCard1 selectCard1;
    public SelectCard3 selectCard3;
    public bool cardSelected = false;

    void OnMouseDown() {
        isCard1Selected.whichCardSelected = 2;
        SelectCard();
        CheckIfActive();
    }

    void SelectCard() {
        Transform selectCard2 = GetComponent<Transform> ();

        if(endTurn.endTheTurn == false) {
            if(isCard1Selected.whichCardSelected == 2) {
                if(placeCard.card2Placed == false) {
                    if(cardSelected == false) {
                        selectCard2.Translate(0.0f, 0.0f, 0.9f);
                        cardSelected = true;
                    }
                    else {
                        selectCard2.Translate(0.0f, 0.0f, -0.9f);
                        cardSelected = false;
                    }
                }
            }
        }
    }

    public void CheckIfActive() {
        if(endTurn.endTheTurn == false) {
            if(cardSelected == false && cardSelected == false && selectCard3.cardSelected == false) {
                placeButton.SetActive(false);
            }
            else {
                placeButton.SetActive(true);
            }
        }
    }
}
