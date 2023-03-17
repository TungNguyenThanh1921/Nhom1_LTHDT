using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentInventory : MonoBehaviour
{
    // Start is called before the first frame update
    public static ContentInventory content_instance;

    void Start()
    {
        content_instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
