using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public string Name;
    public int Level;
    public int Exp;
    public int Money;
    public int HP;
    public int HPCurrent;
    public int MP;
    public int MPCurrent;
    public int ATK;
    public int DEF;
    public static Player instance;
    public void Start()
    {
        instance = this;
    }

    public void Update()
    {
        LevelUp();
        CheckPlayerDie();
    }

    private void LevelUp()
    {
        if(Exp >= 100)
        {
            Level += 1;
            Exp = 0;
            ATK *= 2;
            DEF += ((int)(DEF * 0.4));
            HP += ((int)(HP * 0.4));
            MP += ((int)(MP * 0.4));
            HPCurrent = HP;
            MPCurrent = MP;
        }    
    }    
    private void CheckPlayerDie()
    {
        if (HPCurrent <= 0)
        {
            ReturnMainMapAndRestorePropertiesWhenDie();
        }  
    }
    public void ReturnMainMapAndRestorePropertiesWhenDie()
    {
        SceneManager.LoadScene("MainMap");
        Exp -= 10;
        HPCurrent = HP;
        MPCurrent = MP;
    }
}
