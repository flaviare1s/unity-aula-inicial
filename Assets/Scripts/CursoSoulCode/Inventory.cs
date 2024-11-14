using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int itemCount = 0;
    
    public int ItemCount 
    {
        get { return itemCount; }
        private set { itemCount = value; }
    }

    void Start()
    {
        AddItem();
    }

    public void AddItem()
    {
        ItemCount++;
        Debug.Log("You have " + ItemCount + " items.");
    }
}
