using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandleEquipment : MonoBehaviour
{
    [HideInInspector] public Item Weapon;
    [HideInInspector] public Item Hat;
    [HideInInspector] public Item Shirt;
    [HideInInspector] public Item Trouser;

    public static PlayerHandleEquipment instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void SetEquipment(Item it)
    {
        if (it.Type.Equals("WEAPON"))
        {
            if (Weapon != null)
            {
                Player.instance.ATK -= Weapon.value;
                InventoryManager.instance.Add(Weapon);
            }       
            Weapon = it;
            Player.instance.ATK += Weapon.value;
            EquipmentUIController.instance.Weapon.sprite = it.icon;
            InventoryManager.instance.ItemHandle.RemoveItem();
            InventoryManager.instance.ItemHandle = null;

        }
        if (it.Type.Equals("HAT"))
        {
            if (Hat != null)
            {
                Player.instance.DEF -= Hat.value;
                InventoryManager.instance.Add(Hat);
            }

            Hat = it;
            Player.instance.DEF += Hat.value;
            EquipmentUIController.instance.Hat.sprite = it.icon;
            InventoryManager.instance.ItemHandle.RemoveItem();
            InventoryManager.instance.ItemHandle = null;
        }
        if (it.Type.Equals("SHIRT"))
        {
            if (Shirt != null)
            {
                Player.instance.DEF -= Shirt.value;
                InventoryManager.instance.Add(Shirt);
            }

            Shirt = it;
            Player.instance.DEF += Shirt.value;
            EquipmentUIController.instance.Shirt.sprite = it.icon;
            InventoryManager.instance.ItemHandle.RemoveItem();
            InventoryManager.instance.ItemHandle = null;
        }
        if (it.Type.Equals("TROUSER"))
        {
            if (Trouser != null)
            {
                Player.instance.DEF -= Trouser.value;
                InventoryManager.instance.Add(Trouser);
            }

            Trouser = it;
            Player.instance.DEF += Trouser.value;
            EquipmentUIController.instance.Trouser.sprite = it.icon;
            InventoryManager.instance.ItemHandle.RemoveItem();
            InventoryManager.instance.ItemHandle = null;
        }

        if (it.Type.Equals("HP"))
        {

            int HP_current_player = Player.instance.HPCurrent;
            if (HP_current_player < Player.instance.HP)
            {
                Player.instance.HPCurrent += it.value;
                InventoryManager.instance.ItemHandle.RemoveItem();
                InventoryManager.instance.ItemHandle = null;
            }
          
        }

        if (it.Type.Equals("MP"))
        {
            int MP_current_player = Player.instance.MPCurrent;
            if (MP_current_player < Player.instance.MP)
            {
                Player.instance.MPCurrent += it.value;
                InventoryManager.instance.ItemHandle.RemoveItem();
                InventoryManager.instance.ItemHandle = null;
            }
        }
    }
   
}
