using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
     void PickUp()
    {

       
        InventoryManager.instance.Add(item);
        Destroy(this.gameObject);
       
    }

    private void OnMouseDown()
    {

        PickUp();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        PickUp();
    }
}
