using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string Name;
    public int Level;
    public int OwnExp;
    public int OwnMoney;
    public int HP;
    public int HPCurrent;
    public int ATK;
    public int DEF;
    public static Enemy instance;

    public float latestDirectionChangeTime;
    private readonly float directionChangeTime = 3f;
    private Vector2 movementDirection;
    public Vector2 movementPerSecond;
    private float characterVelocity = 2f;

    private bool isEarnAttackByPlayer;
    private float TimeResetEarnAttackPlayer = 3f;
    private float LastTimeEarnAttacckPlayer;

    private float TimeReturnAttack = 5f;
    private float LastTimeAttack;

    public GameObject ResponEnemyPoint;
    private float EnemySpeed = 0.3f;
    private Vector2 OldPosition;
    [SerializeField] EnemyAnimation EnemyAnimation;
    public bool isMoveRandom = true;
    public bool isAttack = false;
    public BulletController EnemyBullet;
    [SerializeField] protected BulletController EnemyBulletPrefab;
    [SerializeField] List<GameObject> ItemsEnemyOwn;
    public EnemyController enemyController;
    public bool isBoss;

    public void DropItem()
    {
        int ramdon_percent_dropItem = Random.Range(0, 100);
        if (ramdon_percent_dropItem < 99)
        {
            int random = Random.Range(0, 4);
            GameObject item = Instantiate(ItemsEnemyOwn[random], new Vector2(this.gameObject.transform.position.x - 5, this.gameObject.transform.position.y - 5), Quaternion.identity);
            int random_percent_value_item = Random.Range(50, 100);
            item.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);
            item.GetComponent<ItemPickup>().item.value = item.GetComponent<ItemPickup>().item.value + ((item.GetComponent<ItemPickup>().item.value * random_percent_value_item) / 100);
        }

    }
    public void Start()
    {
        instance = this;
        latestDirectionChangeTime = 0f;
        LastTimeAttack = 0f;
        calcuateNewMovementVector();
    }

    public void AttackPlayer()
    {

        if (EnemyBullet != null)
        {
            EnemyBullet.AttackPlayer(this);
        }
    }

    public void calcuateNewMovementVector()
    {
        //create a random direction vector with the magnitude of 1, later multiply it with the velocity of the enemy
        movementDirection = new Vector2(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f)).normalized;
        movementPerSecond = movementDirection * characterVelocity;
    }
    void Update()
    {
        if (isMoveRandom)
        {
            //if the changeTime was reached, calculate a new movement vector
            if (Time.time - latestDirectionChangeTime > directionChangeTime)
            {
                latestDirectionChangeTime = Time.time;
                calcuateNewMovementVector();
            }
            //move enemy: 

            transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime) * EnemySpeed, transform.position.y + (movementPerSecond.y * Time.deltaTime) * EnemySpeed);
            // check animation Enemy
            CheckAnimation(OldPosition, transform.position);
            OldPosition = transform.position;
        }
        else
        {
            // check animation Enemy
            CheckAnimation(OldPosition, Player.instance.transform.position);


        }
        if (isAttack)
        {
            if (Time.time - LastTimeAttack > TimeReturnAttack)
            {
                LastTimeAttack = Time.time;
                if (EnemyBullet == null)
                {
                    EnemyBullet = Instantiate(EnemyBulletPrefab, this.gameObject.transform);
                    EnemyBullet.transform.position = transform.position;

                }
            }


        }

        AttackPlayer();
        EnemyDie();
    }
    private void EnemyDie()
    {
        if (HPCurrent <= 0)
        {
            if(!isBoss)
            {
                DropItem();
            }
          
            Player.instance.Exp += OwnExp;
            Player.instance.Money += OwnMoney;
            SelectionController.instance.ShowOffSelection();
            enemyController.TotalEnemy -= 1;
            Destroy(this.gameObject);
        }    
       
    }
    public void CheckAnimation(Vector2 old_position, Vector2 new_posittion)
    {
        if (new_posittion.x > old_position.x)
        {
            // go right
            EnemyAnimation.StartRight(Name);
        }
        else if (new_posittion.x < old_position.x)
        {
            // go left
            EnemyAnimation.StartLeft(Name);
        }

        else if (new_posittion.y > old_position.y)
        {
            // go up
            EnemyAnimation.StartUp(Name);
        }
        else if (new_posittion.y < old_position.y)
        {
            // go down
            EnemyAnimation.StartDown(Name);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerTagAttack"))
        {
            isEarnAttackByPlayer = true;
            if (Time.time - LastTimeEarnAttacckPlayer > TimeResetEarnAttackPlayer)
            {
                LastTimeEarnAttacckPlayer = Time.time;
                isEarnAttackByPlayer = false;
            }
        }
        if (collision.CompareTag("Wall"))
        {
            if (isEarnAttackByPlayer)
            {
                this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            }
            else
            {
                transform.position = ResponEnemyPoint.transform.position;
            }
        }

    }

    public void StropEnemyfloat()
    {
        StartCoroutine(EnemyFloat(0.5f, this.GetComponent<Rigidbody2D>()));
    }

    IEnumerator EnemyFloat(float time, Rigidbody2D enemyRB)
    {
        yield return new WaitForSeconds(time);
        enemyRB.velocity = Vector2.zero;

    }


}
