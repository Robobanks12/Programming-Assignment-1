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
        if (Input.GetKey(KeyCode.Space))
        {
            m_SpriteRenderer = GetComponent<SpriteRenderer>();
            m_SpriteRenderer.color = Color.blue;
            Debug.Log("Gecko Changes Color");

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}