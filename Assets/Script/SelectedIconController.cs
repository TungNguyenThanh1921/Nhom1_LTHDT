using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedIconController : MonoBehaviour
{
    [HideInInspector] public GameObject PositionSelected;
    [SerializeField] public GameObject Object;
    public static SelectedIconController instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(PositionSelected != null)
        {
            Object.SetActive(true);
          
          
           this.gameObject.transform.position = new Vector2(PositionSelected.transform.position.x, PositionSelected.transform.position.y + 0.3f);
        }   
        else
        {
            Object.SetActive(false);
        }
       
    }
}
