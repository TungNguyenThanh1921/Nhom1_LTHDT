using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRangeAttackEnemy : MonoBehaviour
{
    [SerializeField] Enemy enemy;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enemy.isMoveRandom = false;
            enemy.isAttack = true;
            
           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        enemy.isMoveRandom = true;
        
        enemy.isAttack = false;
    }
 
}
