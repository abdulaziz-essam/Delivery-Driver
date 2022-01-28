using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
bool hasPackages ;
[SerializeField] Color32 hasPackageColor=new Color32(1,1,1,1);
[SerializeField] Color32 notPackageColor=new Color32(1,1,1,1);
SpriteRenderer spriteRenderer;

void Start(){
    //get spriteRenderer component to change it's color'
    spriteRenderer=GetComponent<SpriteRenderer>();
}
 void OnCollisionEnter2D(Collision2D other) {
     Debug.Log("Collision");
    
}
private void OnTriggerEnter2D(Collider2D other)
{
 if(other.tag=="package"&& !hasPackages){
Debug.Log("package picked up");
Destroy(other.gameObject,0.3f);
//make car color like package color
spriteRenderer.color=hasPackageColor;
hasPackages=true;
 }
 if(other.tag=="Customer"&& hasPackages){
     Debug.Log("package delivered");
     hasPackages=false;
     spriteRenderer.color=notPackageColor;
 }
}
}
