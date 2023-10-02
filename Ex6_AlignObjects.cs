using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex6_AlignObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionCube = transform.position;
        GameObject cylinder = GameObject.FindWithTag("MY_CYLINDER");
        GameObject sphere = GameObject.FindWithTag("MY_SPHERE");

        cylinder.transform.position = new Vector3(positionCube.x - 5, positionCube.y, positionCube.z);
        sphere.transform.position = new Vector3(positionCube.x + 5, positionCube.y, positionCube.z);
    }
}
