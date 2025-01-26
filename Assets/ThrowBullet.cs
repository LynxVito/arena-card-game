using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBullet : MonoBehaviour
{
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
