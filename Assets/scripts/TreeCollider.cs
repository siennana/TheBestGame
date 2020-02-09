using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollider : MonoBehaviour
{
    void onCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Tree collision");
            print("collision");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
