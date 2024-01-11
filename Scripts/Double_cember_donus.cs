using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Double_cember_donus : MonoBehaviour
{
    public float donuzHizi;


    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(0f, 0f, donuzHizi);
    }
}
