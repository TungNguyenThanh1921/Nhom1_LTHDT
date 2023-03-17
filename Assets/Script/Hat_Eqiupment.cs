using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat_Eqiupment : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartSlashDown(string hat)
    {
        animator.Play(hat + "Slash_Down");
    }
    public void StartSlashLeft(string hat)
    {
        animator.Play(hat + "Slash_Left");
    }
    public void StartSlashRight(string hat)
    {
        animator.Play(hat + "Slash_Right");
    }
    public void StartSlashUp(string hat)
    {
        animator.Play(hat + "Slash_Up");
    }


    public void StartIDLEDown(string hatidle)
    {
        animator.Play(hatidle + "Down_IDLE");
    }

    public void StartIDLELeft(string hatidle)
    {
        animator.Play(hatidle + "Left_IDLE");
    }

    public void StartIDLERight(string hatidle)
    {
        animator.Play(hatidle + "Right_IDLE");
    }

    public void StartIDLEUp(string hatidle)
    {
        animator.Play(hatidle + "Up_IDLE");
    }



    public void StartDown(string hatdown)
    {
        animator.Play(hatdown + "_Down");
    }

    public void StartUp(string hatup)
    {
        animator.Play(hatup + "_Up");
    }

    public void StartLeft(string hatleft)
    {
        animator.Play(hatleft + "_Left");
    }

    public void StartRight(string hatright)
    {
        animator.Play(hatright + "_Right");
    }

}
