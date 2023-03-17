using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPlayer : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject Colider;
    //[SerializeField] Sprite ThunderSprite;
    //[SerializeField] Sprite BlueFireSprite;
    //[SerializeField] Sprite RedFireSprite;
    //[SerializeField] Sprite WindSprite;

    public void PlaySkill(string skillname)
    {
        


        animator.Play(skillname);
        Colider.SetActive(true);
    }
    public void StopSkill()
    {

        animator.Play("NoneSkill");
        Colider.SetActive(false);
    }

   
}
