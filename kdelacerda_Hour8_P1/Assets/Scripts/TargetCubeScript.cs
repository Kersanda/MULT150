using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   public class TargetCubeScript : MonoBehaviour
{
    //This is the game object you want to access
    private GameObject target;
    // This is here for reference
    void Start()
    {
        target = GameObject.Find("Cube");
    }
    void Update()
    {
        target.transform.Translate(.05f, 0f, 0f);
        target.transform.Rotate(0f, 0f, 1f);
        target.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}

