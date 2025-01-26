using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DeckButton : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject tutorialScreen;
    public GameObject tutorialScreen2;
    public int cardsDrawn = 0;
    public bool showTutorial = false;

    void Start() {
        StartCoroutine(EndTutorial());
    }

    void OnMouseDown() {
        if(showTutorial == true) {
            if(cardsDrawn <= 2) {
                DrawACard();
                cardsDrawn++;
            }
        }
    }

    void DrawACard() {
        Transform drawCard1 = card1.GetComponent<Transform> ();
        Transform drawCard2 = card2.GetComponent<Transform> ();
        Transform drawCard3 = card3.GetComponent<Transform> ();

        if(cardsDrawn == 0) {
            drawCard1.Translate(0.0f, 0.0f, 0.7f);

        }

        if(cardsDrawn == 1) {
            drawCard2.Translate(0.0f, 0.0f, 0.7f);
        }

        if(cardsDrawn == 2) {
            drawCard3.Translate(0.0f, 0.0f, 0.7f);
            tutorialScreen.SetActive(false);
            tutorialScreen2.SetActive(true);
        }
    }

    IEnumerator EndTutorial() {
        yield return new WaitForSeconds(3.5f);
        tutorialScreen.SetActive(true);
        showTutorial = true;
    }
}