using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySelected : MonoBehaviour
{
    [SerializeField] Text Name;
    [SerializeField] Text Level;
    [SerializeField] Text HP;
    [HideInInspector] public Enemy Enemy;
    //public void InitInfo(string _name, string _level, string _hp)
    //{
    //    Name.text = "Name: " + _name;
    //    Level.text = "Level: " + _level;
    //    HP.text = "HP: " + Enemy.HPCurrent.ToString() + " / " + Enemy.HP;
    //}

    public void Update()
    {
        Name.text = "Name: " + Enemy.Name;
        Level.text = "Level: " + Enemy.Level.ToString();
        HP.text = "HP: " + Enemy.HPCurrent.ToString() + " / " + Enemy.HP;
    }
}
