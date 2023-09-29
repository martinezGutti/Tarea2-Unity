using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class RandomPositionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int x = UnityEngine.Random.Range(0,25);
        int y = UnityEngine.Random.Range(0,25);
        int z = UnityEngine.Random.Range(0,25);

        transform.position = new UnityEngine.Vector3(x,y,z);

        if(x > 14) {
            Debug.Log("Position x is far away: Coordinate " + x);
        }
        if(y > 14) {
            Debug.Log("Position y is far away: Coordinate " + y);
        }
        if(z > 14) {
            Debug.Log("Position z is far away: Coordinate " + z);
        }


    }
}
