using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3_Sphere : MonoBehaviour
{
    public UnityEngine.Vector3 myVector_1;
    public UnityEngine.Vector3 myVector_2;

    private UnityEngine.Vector3 old_1; //used for checking, if something has changed
    private UnityEngine.Vector3 old_2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!myVector_1.Equals(old_1) || !myVector_2.Equals(old_2)) {
            old_1 = myVector_1;
            old_2 = myVector_2;

            float mag1 = myVector_1.magnitude;
            float mag2 = myVector_2.magnitude;

            float angle = UnityEngine.Vector3.Angle(myVector_1, myVector_2);
            float distance = UnityEngine.Vector3.Distance(myVector_1, myVector_2);
            
            

            Debug.Log("Magnitude 1: " + mag1);
            Debug.Log("Magnitude 2: " + mag2);
            Debug.Log("Angle: " + angle);
            Debug.Log("Distance: " + distance);

            
        }
    }
}
