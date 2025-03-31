using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light target;
    // Start is called before the first frame update
    void Start()
    {
       target = GameObject.Find("LightBulb").GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.L))
        {
            target.enabled=true;
        }
        else
        {
            target.enabled=false;
        }
    }
}
