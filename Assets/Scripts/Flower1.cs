using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System;
using UnityEngine;

public class Flower1 : MonoBehaviour
{
    public ParticleSystem water;
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
        transform.localScale = transform.localScale * 1.01f;
        /* 
        if the watering can prefab's particle system is hitting the flower
            scale the flower's size over time until it hits a certain size
            flower maxSize is 0.5
         */
    }
}