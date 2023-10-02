using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5_CalculateDistance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spherePosition = transform.position;
        Vector3 cylinderPosition = GameObject.FindWithTag("MY_CYLINDER").transform.position;
        Vector3 cubePosition = GameObject.FindWithTag("MY_CUBE").transform.position;

        float dist_cylinder = Vector3.Distance(spherePosition, cylinderPosition);
        float dist_cube = Vector3.Distance(spherePosition, cubePosition);

        Debug.Log("Distance to cylinder: " + dist_cylinder + "\nDistance to cube: " + dist_cube);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
