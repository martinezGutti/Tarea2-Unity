using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4_SpherePosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector3 position = transform.position;
        Debug.Log("Sphere position: " + position);
    }
}
