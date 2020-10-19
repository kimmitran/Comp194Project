using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class WateringCan : MonoBehaviour
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
        ParticleSystem ps = gameObject.GetComponent<ParticleSystem>();
        var emission = ps.emission;
        transform.rotation.ToAngleAxis( out wateringCanRotation, out axis );

        if (wateringCanRotation > tiltAngleMin && wateringCanRotation < tiltAngleMax)
        {
            
            emission.enabled = true;
        }
        else
        {
            
            emission.enabled = false;
        }
    }
}
