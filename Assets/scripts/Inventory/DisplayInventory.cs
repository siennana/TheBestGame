using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public GameObject inv; // assign in editor
    public bool active = false;

    private void Start()
    {
    //    SetInventoryInactive();
        
    }

    private void Update() // called once per frame
    {
        // Debug.Log("in update");
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("I pressed");
            active = !active;
            Debug.Log(active);
            inv.SetActive(active);
        } 
    }
}
