using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{       bool hasPackage = false;
    [SerializeField] float destroyDelay = .05f;
     [SerializeField] Color32 hasPackageColor = new Color32(227,51,51,51);
     [SerializeField] Color32 hasNoPackageColor = new Color32(1,1,1,1);
        SpriteRenderer spriteRenderer;
         void Start() {
             spriteRenderer = GetComponent<SpriteRenderer>();
        }     
     void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("thang went bang");
    }
     void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("Get triggered bitch");
        if(other.tag == "packagePickup" && hasPackage == false){
            Debug.Log("Meth in trunk, CHECK!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay );
            
        }
        if(other.tag == "packageDropOff" && hasPackage == true){
            Debug.Log("Meth delivered");
            hasPackage = false;
            spriteRenderer.color = hasNoPackageColor;
            Destroy(other.gameObject, destroyDelay );
        }
    }
}
