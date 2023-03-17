using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentUIController : MonoBehaviour
{
    [SerializeField] public Image Weapon;
    [SerializeField] public Image Hat;
    [SerializeField] public Image Shirt;
    [SerializeField] public Image Trouser;

    public static EquipmentUIController instance;
    public void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

}
