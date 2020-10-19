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
            Debug.Log("shovel hit dirt");
            Instantiate(hole, new Vector3(3, 1, 3), Quaternion.identity);
        }
        /* 
        if (shovel object collides with the lower plane){
            get shovel x transform as int (may need cast)
            get shovel z transform as int (may need cast)
            instantiate (hole, new Vector3(var x, set y value, var z), quaternion.identity)
        }
             */
    }
}
