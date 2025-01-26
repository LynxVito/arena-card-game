using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowKnife : MonoBehaviour
{
    public GameObject projectile;
    
    public SelectAbility holdAbility;
    public float projectileSpeed;

    public float cooldownTime = 10;
    private float nextFireTime = 0;

    void Update() {
        if(holdAbility.currentlyHolding == 2) {
            if(Time.time > nextFireTime) {
                if(Input.GetMouseButtonDown(0)) {
                    GameObject knife = Instantiate(projectile, transform.position, transform.rotation);
                    knife.AddComponent<Rigidbody>();
                    knife.AddComponent<BoxCollider>();
                    knife.layer = 6;

                    Rigidbody rb = knife.GetComponent<Rigidbody>();
                    rb.velocity = transform.forward * projectileSpeed;

                    nextFireTime = Time.time + cooldownTime;
                }            
            }
        }
    }          
}
