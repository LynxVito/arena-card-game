using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeProjectile : MonoBehaviour
{
    public GameObject explosion;

    void OnTriggerExit(Collider other) {
        Debug.Log(other);

        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
