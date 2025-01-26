using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

            /**
* This script is based upon an example from a YouTube video by the following creator
*
* Author: Dapper Dino
* Location: https://www.youtube.com/watch?v=ZYeXmze5gxg
* Accessed: 21/Jan/2025
*/
    public float health;
    public float maxHealth;
    public GameObject healthBarUI;
    public Slider slider;
    public GameObject fireBall;
    public GameObject youWinScreen;

    void Start() {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    void Update() {
        slider.value = CalculateHealth();

        if(health < maxHealth) {
            healthBarUI.SetActive(true);
        }

        if(health <= 0) {
            Destroy(gameObject);
            StartCoroutine(YouWin());
        }

        if(health > maxHealth) {
            health = maxHealth;
        }
    }

    float CalculateHealth() {
        return health / maxHealth;
    }

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("FireBall")) {
            health -= 20;
        }
    }

    IEnumerator YouWin() {
        youWinScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Main Menu");
    }
}
