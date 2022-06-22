using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 packageColor = new Color32(1, 1, 0, 1);
    [SerializeField] Color32 originalColor = new Color32(1, 0, 0, 1);

    SpriteRenderer spriteRenderer; 

    bool hasPackage = false;
    [SerializeField] float destroyDelay = 0.5f;

    void private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("whammo!!!");
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "package") {
            Debug.Log("Package picked up!");

            hasPackage = true;
            spriteRenderer.color = packageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        
        if(other.tag == "customer" && hasPackage) {
            Debug.Log("Delivery complete");
            hasPackage = false;
            spriteRenderer.color = originalColor;
        }
    }
}
