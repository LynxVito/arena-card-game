using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DeckButton : MonoBehaviour
{
    public bool deckClicked = false;
    public GameObject cards;

    void Start() {
        MoveTheDeck();
    }

    void OnMouseDown() {
        if(deckClicked == false) {
            deckClicked = true; 
            MoveTheDeck();
        }
    }

    void MoveTheDeck() {      
        Transform drawCards = cards.GetComponent<Transform> ();

        if(deckClicked == true) {
            drawCards.Translate(0.0f, 2.0f, 0.0f);
        }
    }
}