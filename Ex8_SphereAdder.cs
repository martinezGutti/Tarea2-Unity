using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex8_SphereAdder : MonoBehaviour
{
    GameObject[] group2;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere1.transform.position = new Vector3(UnityEngine.Random.Range(-5,5), 0, UnityEngine.Random.Range(-5,5));
        sphere1.transform.tag = "Group 1";

        GameObject sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere2.transform.position = new Vector3(UnityEngine.Random.Range(-5,5), 0, UnityEngine.Random.Range(-5,5));
        sphere2.transform.tag = "Group 1";

        GameObject sphere3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere3.transform.position = new Vector3(UnityEngine.Random.Range(-5,5), 0, UnityEngine.Random.Range(-5,5));
        sphere3.transform.tag = "Group 2";

        GameObject sphere4 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere4.transform.position = new Vector3(UnityEngine.Random.Range(-5,5), 0, UnityEngine.Random.Range(-5,5));
        sphere4.transform.tag = "Group 2";

        GameObject sphere5 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere5.transform.position = new Vector3(UnityEngine.Random.Range(-5,5), 0, UnityEngine.Random.Range(-5,5));
        sphere5.transform.tag = "Group 2";

        group2 = GameObject.FindGameObjectsWithTag("Group 2");

        int nearest = 0;
        float minDist = float.MaxValue;
        int furthest = group2.Length - 1;
        float maxDist = float.MinValue;

        GameObject cube = GameObject.FindGameObjectWithTag("MY_CUBE");

        for (int i = 0; i < group2.Length; i++)
        {
            var sphere = group2[i];
            var distance = Vector3.Distance(cube.transform.position, sphere.transform.position);
            if(distance < minDist) {
                nearest = i;
                minDist = distance;
            }

            if(distance > maxDist) {
                furthest = i;
                maxDist = distance;
            }
        }

        //get nearest on first position
        var temp = group2[0];
        group2[0] = group2[nearest];
        group2[nearest] = temp;

        //get furthest on last position
        temp = group2[group2.Length-1];
        group2[group2.Length-1] = group2[furthest];
        group2[furthest] = temp;

        group2[nearest].transform.position += new Vector3(0,5,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            var cubeRenderer = group2[group2.Length - 1].GetComponent<Renderer>();
            Color randomColor = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f));
            cubeRenderer.material.SetColor("_Color", randomColor);
        }
    }
}
