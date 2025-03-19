using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
            for (int count = 22; count <= 100; count+=2)
            {
                Debug.Log(count);
            }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
