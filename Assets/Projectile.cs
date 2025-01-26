using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
            /**
* This script is based upon an example from a YouTube video by the following creator
*
* Author: Dapper Dino
* Location: https://www.youtube.com/watch?v=cLkj6Ewap14&t=1s
* Accessed: 21/Jan/2025
*/
    public GameObject explosion;

    void OnTriggerEnter(Collider other) {
        Debug.Log(other);
        
        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
