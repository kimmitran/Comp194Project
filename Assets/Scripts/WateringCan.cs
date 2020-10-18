using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float tiltAngleMin = 0.0f;
    float tiltAngleMax = 180.0f;
    // Start is called before the first frame update
    void Start()
    {

        
    
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float wateringCanRotation; 
        Vector3 axis;
        var emission = ParticleSystem.emission;
        transform.rotation.ToAngleAxis( out wateringCanRotation, out axis );

        if (wateringCanRotation > tiltAngleMin && wateringCanRotation < tiltAngleMax)
        {
            emission = gameObject.GetComponent<ParticleSystem>();
            emission.enabled = true;
        }
        else
        {
            emission = gameObject.GetComponent<ParticleSystem>();
            emission.enabled = false;
        }
    }
}
