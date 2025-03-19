using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int count = 1; count <= 31; count += 1)
        {
            if (count == 16)
            {
                Debug.Log("It's my birthday!");
                    }
            else {
                Debug.Log(count);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
