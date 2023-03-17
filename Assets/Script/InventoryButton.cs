using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryButton : MonoBehaviour
{
    public InventoryManager InventoryManger;
    public GameObject Inventory;
    [SerializeField] Button OpenInventory;
    [SerializeField] GameObject Equipment;
    [SerializeField] public Button ButtonClose;
    [SerializeField] public Button UseButton;
    // Start is called before the first frame update
    void Start()
    {
        OpenInventory.onClick.AddListener(Open);
        ButtonClose.onClick.AddListener(CloseButton);
    }
    public void Open()
    {
        InventoryManger.ListItems();
        Inventory.SetActive(true);
        Equipment.SetActive(true);
        UseButton.gameObject.SetActive(true);
        UseButton.onClick.AddListener(InventoryManger.UseItem);

    }

    public void CloseButton()
    {
        InventoryManger.clearObjItem();
        Inventory.SetActive(false);
        Equipment.SetActive(false);
        UseButton.gameObject.SetActive(false);
        InventoryManger.NameItem.gameObject.SetActive(false);
        InventoryManger.ValueItem.gameObject.SetActive(false);
    }

}
