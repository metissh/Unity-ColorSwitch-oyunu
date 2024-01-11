using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondur : MonoBehaviour
{
    public static float donuzHizi;


    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(0f, 0f, donuzHizi);
    }
}
