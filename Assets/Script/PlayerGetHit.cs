using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetHit : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BulletController bl = collision.gameObject.GetComponent<BulletController>();
        if ((bl.EnemyOwn.ATK - Player.instance.DEF) > 0)
        {
            Player.instance.HPCurrent -= (bl.EnemyOwn.ATK - Player.instance.DEF);
        }    
        
    }
}
