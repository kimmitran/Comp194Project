using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    //float tiltAngleMin = 50.0f; //was 0
    //float tiltAngleMax = 75.0f; //was 180
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
        //wateringCanRotation = transform.localEulerAngles.z;
        if (wateringCanRotation > 50 && wateringCanRotation < 75){
            //Debug.Log("water should be playing");
            //Debug.Log($"can is tilted at {wateringCanRotation}");
            waterEffect.Emit(1);
            wateringNoise.Play();
        }
        else{
            //Debug.Log("no water");
            //Debug.Log($"can is tilted at {wateringCanRotation}");
            waterEffect.Stop();
            wateringNoise.Stop();
        }
    }
}
