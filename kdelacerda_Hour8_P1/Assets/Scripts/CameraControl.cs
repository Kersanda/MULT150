using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //This is the game object you want to access
    private GameObject target;
    void Start()
    {
        target = GameObject.FindWithTag("TagYourIt");
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        target.transform.Translate(mxVal, myVal, 0f);
    }
}
