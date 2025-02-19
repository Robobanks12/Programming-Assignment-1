using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkScript : MonoBehaviour
{

    void Start()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("The shark jumps out and crashes through the glass sheet and lands on the ground, he eventually passes away due to a lack of movement");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
