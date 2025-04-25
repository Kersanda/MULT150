using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    private int collisionCount = 0;
    public int collisionThreshold = 7;
    public bool isSolved = false;
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            collisionCount++;
            Destroy(collidedWith);
            if (collisionCount >= collisionThreshold)
            {
                isSolved = true;
            }
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
