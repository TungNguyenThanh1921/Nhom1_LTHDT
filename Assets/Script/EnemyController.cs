using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
  
    [SerializeField] List<GameObject> ResponEnemyPoint = new List<GameObject>();
    [SerializeField] List<Enemy> Enemys = new List<Enemy>();
    [SerializeField] int NumEnemy;
    [SerializeField] GameObject PointDoneFloor;
    public int TotalEnemy = 0;
    bool isStartCheck = false;
    public void InitEnemy(bool isHardMode)
    {
        for (int posittionEnemy = 0; posittionEnemy < ResponEnemyPoint.Count; posittionEnemy++)
        {
            for (int num_enemy_spawn = 0; num_enemy_spawn < NumEnemy; num_enemy_spawn++)
            {
                Enemy spawnenemy = Instantiate(Enemys[posittionEnemy], ResponEnemyPoint[posittionEnemy].transform);
                spawnenemy.ResponEnemyPoint = ResponEnemyPoint[posittionEnemy];
                spawnenemy.enemyController = this;
                if(isHardMode)
                {
                    HardModeProperties(spawnenemy);
                }
                if (!isStartCheck)
                    isStartCheck = true;
                TotalEnemy += 1;
            }
        }    
    }

    public void Update()
    {
        if(isStartCheck)
        {
            if (TotalEnemy <= 0)
            {
                Player.instance.transform.position = new Vector2(PointDoneFloor.transform.position.x, PointDoneFloor.transform.position.y);
                isStartCheck = false;
            }
        }
       
    }

    public void HardModeProperties(Enemy _enemy)
    {
        _enemy.ATK *= 2;
        _enemy.DEF *= 2;
        _enemy.HP *= 2;
        _enemy.OwnExp *= 2;
        _enemy.OwnMoney *= 2;
        _enemy.HPCurrent = _enemy.HP;
    }
  

   

}
