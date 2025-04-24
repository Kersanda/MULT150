using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int times_bounce;
    // Start is called before the first frame update
    void Start()
    {
        times_bounce=0;
    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Sphere")
        {
            times_bounce++;
            Debug.Log("Bouncy ball "+times_bounce +" times!");
        }
    }
}
