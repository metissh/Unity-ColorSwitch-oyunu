using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temizleyici : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        Destroy(temas.gameObject);
    }
}
