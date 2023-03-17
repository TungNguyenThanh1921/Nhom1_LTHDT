using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    public Item item;
    public Button RemoveButton;
    [SerializeField] public Image IconImage;
    [SerializeField] public Text NameText;
    [SerializeField] Button SelectItemInInventory;

    public InventoryManager inven;
    public static InventoryItemController instance;
    public void RemoveItem()
    {
        if (item != null)
        {
            inven.Remove(item);
            Destroy(gameObject);
        }
     
       
    }


    public void ShowInFoItemWhenSelected()
    {
        if (item != null)
        {
            InventoryManager.instance.ShowInFoItem(item.itemname, item.value.ToString());
            InventoryManager.instance.ItemHandle = this;
        }    
       

    }
    public void AddItem(Item newItem)
    {
        item = newItem;
    }

    private void Start()
    {
        if (instance == null)
            instance = this;
        SelectItemInInventory.onClick.AddListener(ShowInFoItemWhenSelected);

    }
}
