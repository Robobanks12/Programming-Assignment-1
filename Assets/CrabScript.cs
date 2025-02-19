using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabScript : MonoBehaviour
{

        // Crab jumps upon interaction
    void Start()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("The crab is scared and procceds to run away");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
