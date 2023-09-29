using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2_ColorName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color c = gameObject.GetComponent<MeshRenderer>().material.color;
        String name = this.name;

        Debug.Log("Color: " + c + "\nName: " + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
