using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
    }
}
