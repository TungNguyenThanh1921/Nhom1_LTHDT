using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trousers_Equipment : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator = GetComponent<Animator>();
    }

    public void StartSlashDown(string trouser)
    {
        animator.Play(trouser+"Slash_Down");
    }
    public void StartSlashLeft(string trouser)
    {
        animator.Play(trouser + "Slash_Left");
    }
    public void StartSlashRight(string trouser)
    {
        animator.Play(trouser + "Slash_Right");
    }
    public void StartSlashUp(string trouser)
    {
        animator.Play(trouser + "Slash_Up");
    }




    public void StartIDLEDown(string trousersidle)
    {
        animator.Play(trousersidle + "Down_IDLE");
    }

    public void StartIDLELeft(string trousersidle)
    {
        animator.Play(trousersidle + "Left_IDLE");
    }

    public void StartIDLERight(string trousersidle)
    {
        animator.Play(trousersidle + "Right_IDLE");
    }

    public void StartIDLEUp(string trousersidle)
    {
        animator.Play(trousersidle + "Up_IDLE");
    }


    public void StartDown(string trouserdown)
    {
        animator.Play(trouserdown+"_Down");
    }

    public void StartUp(string trouserup)
    {
        animator.Play(trouserup+"_Up");
    }

    public void StartLeft(string trouserleft)
    {
        animator.Play(trouserleft + "_Left");
    }

    public void StartRight(string trouserright)
    {
        animator.Play(trouserright+"_Right");
    }

}
