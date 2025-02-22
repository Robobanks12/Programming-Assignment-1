using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChimpScript : MonoBehaviour
{
    AudioSource aud;
    Collider2D soundTrigger;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log ("The monkey goes Oo aoaa oo");
            aud = GetComponent<AudioSource>();
            soundTrigger = GetComponent<Collider2D>();
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {   
        if (collider.gameObject.tag == "Player")
        {
            aud.Play();
            Debug.Log ("The monkey goes Oo aoaa oo again");
        }
           
    }

}
