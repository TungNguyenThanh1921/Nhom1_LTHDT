using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;
  
    public void StartDown(string enemyname)
    {
        animator.Play(enemyname + "Down");
    }

    public void StartLeft(string enemyname)
    {
        animator.Play(enemyname + "Left");
    }
    public void StartRight(string enemyname)
    {
        animator.Play(enemyname + "Right");
    }
    public void StartUp(string enemyname)
    {
        animator.Play(enemyname + "Up");
    }
}
