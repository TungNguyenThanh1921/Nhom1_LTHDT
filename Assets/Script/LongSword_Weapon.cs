using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongSword_Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    [SerializeField] Collider2D HitLeft;
    [SerializeField] Collider2D HitRight;
    [SerializeField] Collider2D HitUp;
    [SerializeField] Collider2D HitDown;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator = GetComponent<Animator>();
    }
    void SetHitActive(bool left, bool right, bool up, bool down)
    {
        HitDown.gameObject.SetActive(down);
        HitRight.gameObject.SetActive(right);
        HitLeft.gameObject.SetActive(left);
        HitUp.gameObject.SetActive(up);
    }
    public void StartDown(string weapon)
    {
        animator.Play(weapon + "_Down");
        SetHitActive(false, false, false, true);
    }

    public void StartUp(string weapon)
    {
        animator.Play(weapon + "_Up");
        SetHitActive(false, false, true, false);
    }

    public void StartLeft(string weapon)
    {
        animator.Play(weapon + "_Left");
        SetHitActive(true, false, false, false);
    }

    public void StartRight(string weapon)
    {

        animator.Play(weapon + "_Right");
        SetHitActive(false, true, false, false);
    }

    public void Stop(string weapon)
    {
        SetHitActive(false, false, false, false);
        animator.Play(weapon + "_None");
     
    }

   

}
