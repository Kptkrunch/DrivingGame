using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destroyDelay = 0.5f;

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("whammo!!!");
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "package") {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        
        if(other.tag == "customer" && hasPackage) {
            Debug.Log("Delivery complete");
            hasPackage = false;
        }
    }
}
