using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    float tiltAngleMin = 50.0f;
    float tiltAngleMax = 75.0f;
    public AudioSource wateringNoise;
    public ParticleSystem waterEffect;
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
        transform.rotation.ToAngleAxis( out wateringCanRotation, out axis );
        if (wateringCanRotation > tiltAngleMin && wateringCanRotation < tiltAngleMax)
        {
            waterEffect.Emit(1);
            wateringNoise.Play();
        }
        else
        {
            waterEffect.Stop();
            wateringNoise.Stop();
        }
    }
}
