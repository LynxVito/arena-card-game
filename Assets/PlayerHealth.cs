using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

            /**
* This script is based upon an example from a YouTube video by the following creator
*
* Author: Dapper Dino
* Location: https://www.youtube.com/watch?v=ZYeXmze5gxg
* Accessed: 21/Jan/2025
*/
    public float health = 100;
    public float maxHealth = 100;
    public Slider slider;

    void Start() {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    void Update() {
        slider.value = CalculateHealth();

        if(health > maxHealth) {
            health = maxHealth;
        }

        if(health < 0) {
            health = 0;
        }
    }

    float CalculateHealth() {
        return health / maxHealth;
    }
}
