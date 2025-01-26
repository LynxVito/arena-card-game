using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaceOpponentCards : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject placeButton;
    public GameObject endTurnButton;
    public GameObject tutorialScreen3;
    public bool endTheTurn = false;

    public void OpponentPlaceCards() {
        card1.SetActive(true);
        card2.SetActive(true);
        card3.SetActive(true);
        card4.SetActive(true);
    }

    public void EndTurn() {
        endTheTurn = true;
        placeButton.SetActive(false);
        endTurnButton.SetActive(false);
        tutorialScreen3.SetActive(true);

        StartCoroutine(NextScene());
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(5.5f);
        tutorialScreen3.SetActive(false);
        SceneManager.LoadScene("Arena scene");
    }
}
