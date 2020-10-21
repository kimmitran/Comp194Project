using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System;
using UnityEngine;

public class Flower1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other)
    {
        /* if (other.gameObject.name == "Flower1"){
            if (other.gameObject.transform.localScale.x < 0.5){
                Debug.Log("particles biggening flower"); */
                transform.localScale = transform.localScale * 1.01f;
            //}
        //}
        /* 
        if the watering can prefab's particle system is hitting the flower
            scale the flower's size over time until it hits a certain size
            flower maxSize is 0.5
         */
    }
}