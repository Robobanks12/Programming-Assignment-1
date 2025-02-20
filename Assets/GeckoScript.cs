using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeckoScript : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;
    float m_Red, m_Blue, m_Green;
    void Start()
    {
        float randomNumber = Random.Range(0, 3);
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            int randomNumber = Random.Range(0, 3);


            
            if (randomNumber == 0)
            {
                m_SpriteRenderer = GetComponent<SpriteRenderer>();
                m_SpriteRenderer.color = Color.blue;
                Debug.Log("Gecko Changes Color to blue");
            }
            if (randomNumber == 1)
            {
                m_SpriteRenderer = GetComponent<SpriteRenderer>();
                m_SpriteRenderer.color = Color.green;
                Debug.Log("Gecko Changes Color to green");
            }
            if (randomNumber == 2)
            {
                m_SpriteRenderer = GetComponent<SpriteRenderer>();
                m_SpriteRenderer.color = Color.red;
                Debug.Log("Gecko Changes Color to red");
            }

            if (randomNumber == 3)
            {
                m_SpriteRenderer = GetComponent<SpriteRenderer>();
                m_SpriteRenderer.color = Color.white;
                Debug.Log("Gecko Changes Color to normal");
            }
        }

    }
}