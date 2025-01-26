using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCard3 : MonoBehaviour
{
    public SelectCard1 card1Select;
    public PlaceCard placeCard;
    public PlaceOpponentCards endTurn;
    public GameObject placeButton;
    public SelectCard1 selectCard1;
    public SelectCard2 selectCard2;
    public bool cardSelected = false;

    void OnMouseDown() {
        card1Select.whichCardSelected = 3;
        SelectCard();
        CheckIfActive();
    }

    void SelectCard() {
        Transform selectCard3 = GetComponent<Transform> ();

        if(endTurn.endTheTurn == false) {
            if(card1Select.whichCardSelected == 3) {
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
            if(cardSelected == false && selectCard2.cardSelected == false && cardSelected == false) {
                placeButton.SetActive(false);
            }
            else {
                placeButton.SetActive(true);
            }
        }
    }
}
