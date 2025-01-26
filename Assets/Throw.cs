using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFire : MonoBehaviour
{
    public GameObject projectile;
    public SelectAbility holdAbility;
    public float projectileSpeed;

    public float cooldownTime = 10;
    private float nextFireTime = 0;

    void Update() {

        if(holdAbility.currentlyHolding == 1) {
            if(Time.time > nextFireTime) {
                if(Input.GetMouseButtonDown(0)) {
                    GameObject fireball = Instantiate(projectile, transform.position, transform.rotation);
                    Rigidbody rb = fireball.GetComponent<Rigidbody>();
                    rb.velocity = transform.forward * projectileSpeed;

                    nextFireTime = Time.time + cooldownTime;
                }            
            }            
        }

    }
}
