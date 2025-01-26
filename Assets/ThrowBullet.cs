using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBullet : MonoBehaviour
{

            /**
* This script is based upon an example from a YouTube video by the following creator
*
* Author: Dapper Dino
* Location: https://www.youtube.com/watch?v=cLkj6Ewap14&t=1s
* Accessed: 21/Jan/2025
*/
    public GameObject projectile;
    public SelectAbility holdAbility;
    public float projectileSpeed;

    public float cooldownTime = 0.1f;
    private float nextFireTime = 0;

    void Update() {
        if(holdAbility.currentlyHolding == 0) {
            if(Time.time > nextFireTime) {
                if(Input.GetMouseButtonDown(0)) {
                    GameObject bullet = Instantiate(projectile, transform.position, transform.rotation);
                    Rigidbody rb = bullet.GetComponent<Rigidbody>();
                    rb.velocity = transform.forward * projectileSpeed;

                    nextFireTime = Time.time + cooldownTime;
                }            
            }            
        }

    }
}
