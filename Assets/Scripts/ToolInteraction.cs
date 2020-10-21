using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolInteraction : MonoBehaviour
{
    public AudioSource shovelPickUp;
    public AudioSource wateringCanPickUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
    void OnTriggerEnter(Collider tool){
        if (tool.gameObject.name == "Shovel"){
            shovelPickUp.Play();
        }
        else if (tool.gameObject.name == "WateringCanPrefab"){
            wateringCanPickUp.Play();
        }
    }
}
