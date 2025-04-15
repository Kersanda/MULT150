using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target=GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            target.transform.Translate(0.005f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            target.transform.Translate(-0.005f, 0f, 0f);
        }
    }
}

