using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolInteraction : MonoBehaviour
{
    public GameObject hole;
    public AudioSource digNoise;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
    void OnTriggerEnter(Collider lowerLayer){
        if(lowerLayer.gameObject.name == "Lower Plane"){
            float xCoord = transform.position.x;
            float zCoord = transform.position.z;
            digNoise.Play();
            Instantiate(hole, new Vector3(xCoord, -0.016f, zCoord), Quaternion.identity);
        }
    }
}
