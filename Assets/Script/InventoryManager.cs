using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public InventoryItemController InventoryItem;
    public List<InventoryItemController> inventoryItems;
    public Toggle toggleremove;
    public GameObject[] invenlist;
    [SerializeField] public InventoryButton InventoryButton;
    [SerializeField] public Text NameItem;
    [SerializeField] public Text ValueItem;
    [SerializeField] public GameObject HandleItemPickup;
 

    [HideInInspector] public InventoryItemController ItemHandle;


    public void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Update()
    {
        EnableItemsRemove();
    }
    private void OnLevelWasLoaded(int level)
    {

        invenlist = GameObject.FindGameObjectsWithTag("InventoryManager");
        if (invenlist.Length > 1)
        {
            Destroy(invenlist[1]);
        }
    }
    public void Add(Item item)
    {
        Items.Add(Instantiate(item, HandleItemPickup.transform));
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void clearObjItem()
    {
        
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
            
        }
   
    }
    public void ListItems()
    {

        clearObjItem();
        foreach (var item in Items)
        {
            InventoryItemController obj = Instantiate(InventoryItem, ItemContent);
            obj.inven = this;
            obj.NameText.text = item.itemname;
            obj.IconImage.sprite = item.icon;

            if (toggleremove.isOn)
            {
                obj.RemoveButton.gameObject.SetActive(true);
            }
            obj.AddItem(item);
        }
    }

    public void EnableItemsRemove()
    {
        if (toggleremove.isOn)
        {
            foreach (Transform item in ItemContent)
            {
                item.Find("RemoveButton").gameObject.SetActive(true);
            }
        }
        else
        {
            foreach (Transform item in ItemContent)
            {
                item.Find("RemoveButton").gameObject.SetActive(false);
            }
        }
    }



    public void ShowInFoItem(string _name, string _value)
    {
        NameItem.gameObject.SetActive(true);
        ValueItem.gameObject.SetActive(true);
        NameItem.text = "Name: " + _name;
        ValueItem.text = "Value: " + _value;
    }
    public void UseItem()
    {
        if(ItemHandle != null)
        {
            PlayerHandleEquipment.instance.SetEquipment(ItemHandle.item);
            ListItems();
        }
    }
}
