using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralax : MonoBehaviour
{
 private MeshRenderer meshrenderer;
 public float animationspeed=1f;
 private void Awake(){
     meshrenderer=GetComponent<MeshRenderer>();


 }
    private void Update(){
        meshrenderer.material.mainTextureOffset+=new Vector2(animationspeed*Time.deltaTime,0);
    }

}
