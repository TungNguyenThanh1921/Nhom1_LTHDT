using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shirt_Equipment : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSlashDown(string shirt)
    {
        animator.Play(shirt + "Slash_Down");
    }
    public void StartSlashLeft(string shirt)
    {
        animator.Play(shirt + "Slash_Left");
    }
    public void StartSlashRight(string shirt)
    {
        animator.Play(shirt + "Slash_Right");
    }
    public void StartSlashUp(string shirt)
    {
        animator.Play(shirt + "Slash_Up");
    }

    public void StartIDLEDown(string shirtidle)
    {
        animator.Play(shirtidle + "Down_IDLE");
    }

    public void StartIDLELeft(string shirtidle)
    {
        animator.Play(shirtidle + "Left_IDLE");
    }

    public void StartIDLERight(string shirtidle)
    {
        animator.Play(shirtidle + "Right_IDLE");
    }

    public void StartIDLEUp(string shirtidle)
    {
        animator.Play(shirtidle + "Up_IDLE");
    }


    public void StartDown(string shirtdown)
    {
        animator.Play(shirtdown + "_Down");
    }


    public void StartUp(string shirtup)
    {
        animator.Play(shirtup + "_Up");
    }


    public void StartLeft(string shirtleft)
    {
        animator.Play(shirtleft + "_Left");
    }


    public void StartRight(string shirtright)
    {
        animator.Play(shirtright + "_Right");
    }

}
