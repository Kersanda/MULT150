using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    public int chaosCounter=0;
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if(collidedWith.tag==gameObject.tag)
        {
        if(collidedWith.tag=="Chaos")
        {
            chaosCounter++;
            if(chaosCounter>=7)
            {
                isSolved=true;
                GetComponent<Light>().enabled=true;
            }
        }
        else if(collidedWith.tag!="Chaos")
        {
            isSolved=true;
            GetComponent<Light>().enabled=false; 
        }
            Destroy (collidedWith);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
