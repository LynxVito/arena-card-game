using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject explosion;

    void OnTriggerEnter(Collider other) {
        Debug.Log(other);
        
        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
