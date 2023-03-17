using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour
{
    [SerializeField] GameObject ChoooseFloor;
    public static PopupController instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        ChoooseFloor.SetActive(false);
    }

    public void ShowSelectedFloor()
    {
        ChoooseFloor.SetActive(true);
    }
    public void ShowOffSelectedFloor()
    {
        ChoooseFloor.SetActive(false);
    }
}
