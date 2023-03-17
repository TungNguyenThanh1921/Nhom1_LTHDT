using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHitEnemy : MonoBehaviour
{
    [SerializeField] PlayerController playercontroller;
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        try
        {
            Rigidbody2D rbEnemy = collision.GetComponent<Rigidbody2D>();

            if (rbEnemy != null)
            {
                if(playercontroller.LongSword.Equals("LongSword"))
                {
                    rbEnemy.isKinematic = false;
                    Vector2 diff = rbEnemy.transform.position - transform.position;
                    diff = diff.normalized * 0.3f;
                    rbEnemy.AddForce(diff, ForceMode2D.Impulse);
                    Enemy _enemy = collision.gameObject.GetComponent<Enemy>();
                    if (Player.instance.ATK - _enemy.DEF > 0)
                    {
                        _enemy.HPCurrent -= (Player.instance.ATK - _enemy.DEF);
                    }
                    else
                    {
                        _enemy.HPCurrent -= 1;
                    }
                    rbEnemy.isKinematic = true;
                    _enemy.StropEnemyfloat();
                }
                else
                {
                    rbEnemy.isKinematic = false;
                    Vector2 diff = rbEnemy.transform.position - transform.position;
                    diff = diff.normalized * 0.2f;
                    rbEnemy.AddForce(diff, ForceMode2D.Impulse);
                    Enemy _enemy = collision.gameObject.GetComponent<Enemy>();
                    if (Player.instance.ATK - _enemy.DEF > 0)
                    {
                        _enemy.HPCurrent -= (Player.instance.ATK - _enemy.DEF) * 2;
                    }
                    else
                    {
                        _enemy.HPCurrent -= 1;
                    }
                    rbEnemy.isKinematic = true;
                    _enemy.StropEnemyfloat();
             
                }
               


            }

        }
        catch
        {

        }

   

    }
  
}
