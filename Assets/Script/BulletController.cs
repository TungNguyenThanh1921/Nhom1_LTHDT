using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public Enemy EnemyOwn;

    public void AttackPlayer(Enemy enemy)
    {  
        if(EnemyOwn == null)
        {
            EnemyOwn = enemy;
        }
        Vector2 bullet = this.transform.position;
        Vector2 player = Player.instance.transform.position;  
        float distance = Vector2.Distance(bullet, player);
        transform.position = new Vector2(bullet.x + ((0.5f / distance) * (player.x - bullet.x)) * 0.05f, bullet.y + ((0.5f / distance) * (player.y - bullet.y)) * 0.05f);     
    } 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
     
    }
}
