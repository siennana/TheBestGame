using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public GameObject inv; // assign in editor
    public bool active;

    private void Start()
    {
        SetInventoryInactive();
    }

    private void Update() // called once per frame
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("I pressed");
            SetInventoryActive();
        } 
        else
        {
            //Debug.Log("I not pressed");
            //SetInventoryInactive();
        }
    }

    private void SetInventoryActive()
    {
        active = true;
        inv.SetActive(active);
        Debug.Log("Inventory active");
    }

    private void SetInventoryInactive()
    {
        active = false;
        inv.SetActive(active);
        Debug.Log("Inventory Inactive");
    }

}
