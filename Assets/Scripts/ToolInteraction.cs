using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolInteraction : MonoBehaviour
{
    public GameObject hole;
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

            Instantiate(hole, new Vector3(176, 3, 219), Quaternion.identity);
        }
    }
    //void OnCollisionEnter(Collider lowerLayer){
        //if(collision.gameObject.name == "shovel");
        /* 
        if (shovel object collides with the lower plane){
            var x = get shovel x transform as int or float
            var z = get shovel z transform as int or float
            instantiate (hole, new Vector3(var x, set y value, var z), quaternion.identity)
            GameObject.FindGameObjectWithTag(shovel).transform.position
        }
             */
    //}
}
