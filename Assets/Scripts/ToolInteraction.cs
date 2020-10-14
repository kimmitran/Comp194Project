using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolInteraction : MonoBehaviour
{
    public GameObject shovel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shovel.transform.position.y == -0.5){
            Debug.Log("dug a hole");
        }
        /* 
        if (shovel object touches lower layer){
            play digging animation
        }
             */
    }
}
