using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public GameObject inv; // assign in editor
    public bool active = false;

    private void Start()
    {
        inv.SetActive(false);        
    }

    private void Update() // called once per frame
    {
        // Debug.Log("in update");
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("I pressed");
            active = !active;
            inv.SetActive(active);
        } 
    }
}
