using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    Transform topPoz;
    void Start()
    {
        topPoz = GameObject.Find("top").GetComponent<Transform>();
    }

    
    void Update()
    {
        if(topPoz.position.y > transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, topPoz.position.y);
        }
    }
}
