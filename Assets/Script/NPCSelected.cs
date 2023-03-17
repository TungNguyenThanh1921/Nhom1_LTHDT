using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCSelected : MonoBehaviour
{
    [SerializeField] Text Name;
    [SerializeField] Text Level;

    public void InitInfo(string _name, string _level)
    {
        Name.text = "Name: " + _name;
        Level.text = "Level: " + _level;    
    }    
    

}
