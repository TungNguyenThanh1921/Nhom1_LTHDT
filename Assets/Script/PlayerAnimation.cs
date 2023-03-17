using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    PlayerController playercontroller;
    const string PLAYER_IDLE_DOWN = "Player_Downidle";
    const string PLAYER_IDLE_LEFT = "Player_Leftidle";
    const string PLAYER_IDLE_RIGHT = "Player_Rightidle";
    const string PLAYER_IDLE_UP = "Player_Upidle";

    const string PLAYER_MOVE_LEFT = "Player_WalkLeft";
    const string PLAYER_MOVE_RIGHT = "Player_WalkRight";
    const string PLAYER_MOVE_UP = "Player_WalkUp";
    const string PLAYER_MOVE_DOWN = "Player_WalkDown";

    const string PLAYER_ATTACK_DOWN = "Player_Slash_Down";
    const string PLAYER_ATTACK_LEFT = "Player_Slash_Left";
    const string PLAYER_ATTACK_RIGHT = "Player_Slash_Right";
    const string PLAYER_ATTACK_UP = "Player_Slash_Up";



    const string PLAYER_SKILL_ATTACK = "Player_air_attack";
    private string currentState;

    public Hat_Eqiupment hat_equipment;
    public Shirt_Equipment shirt_equipment;
    public Trousers_Equipment trousers_equipment;
    public LongSword_Weapon longSword_weapon;
    public SkillPlayer skill_player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playercontroller.playergetinputvalue.isSlash == true)
        {
            playercontroller.playermovement.isstatus_move = false;
            Invoke("AttackComplete", playercontroller.attackdelay);
            if (playercontroller.playermovement.current_derection == "right")
            {
                ChangeState(PLAYER_ATTACK_RIGHT);
                hat_equipment.StartSlashRight(playercontroller.Hat_Eqiupment);
                shirt_equipment.StartSlashRight(playercontroller.Shirt_Equipment);
                trousers_equipment.StartSlashRight(playercontroller.Trouser_Eqiupment);
                if (playercontroller.LongSword == "LongSword")
                {
                    longSword_weapon.StartRight(playercontroller.LongSword);
                }
                else
                {
                    if (SelectionController.instance.GameObjectWasSelected != null)
                    {
                        skill_player.PlaySkill(playercontroller.LongSword);
                        skill_player.gameObject.transform.position = new Vector2(SelectionController.instance.GameObjectWasSelected.transform.position.x, SelectionController.instance.GameObjectWasSelected.transform.position.y + 0.3f);
                        
                    }

                }
            }
            else if (playercontroller.playermovement.current_derection == "left")
            {
                ChangeState(PLAYER_ATTACK_LEFT);
                hat_equipment.StartSlashLeft(playercontroller.Hat_Eqiupment);
                shirt_equipment.StartSlashLeft(playercontroller.Shirt_Equipment);
                trousers_equipment.StartSlashLeft(playercontroller.Trouser_Eqiupment);
                if (playercontroller.LongSword == "LongSword")
                {
                    longSword_weapon.StartLeft(playercontroller.LongSword);
                }
                else
                {
                    if (SelectionController.instance.GameObjectWasSelected != null)
                    {
                        skill_player.PlaySkill(playercontroller.LongSword);
                        skill_player.gameObject.transform.position = new Vector2(SelectionController.instance.GameObjectWasSelected.transform.position.x, SelectionController.instance.GameObjectWasSelected.transform.position.y + 0.3f);

                    }

                }
            }
            else if (playercontroller.playermovement.current_derection == "down")
            {
                ChangeState(PLAYER_ATTACK_DOWN);
                hat_equipment.StartSlashDown(playercontroller.Hat_Eqiupment);
                shirt_equipment.StartSlashDown(playercontroller.Shirt_Equipment);
                trousers_equipment.StartSlashDown(playercontroller.Trouser_Eqiupment);
                if (playercontroller.LongSword == "LongSword")
                {
                    longSword_weapon.StartDown(playercontroller.LongSword);
                }
                else
                {
                    if (SelectionController.instance.GameObjectWasSelected != null)
                    {
                        skill_player.PlaySkill(playercontroller.LongSword);
                        skill_player.gameObject.transform.position = new Vector2(SelectionController.instance.GameObjectWasSelected.transform.position.x, SelectionController.instance.GameObjectWasSelected.transform.position.y + 0.3f);

                    }

                }
            }
            else if (playercontroller.playermovement.current_derection == "up")
            {
                ChangeState(PLAYER_ATTACK_UP);
                hat_equipment.StartSlashUp(playercontroller.Hat_Eqiupment);
                shirt_equipment.StartSlashUp(playercontroller.Shirt_Equipment);
                trousers_equipment.StartSlashUp(playercontroller.Trouser_Eqiupment);
                if (playercontroller.LongSword == "LongSword")
                {
                    longSword_weapon.StartUp(playercontroller.LongSword);
                }
                else
                {
                    if (SelectionController.instance.GameObjectWasSelected != null)
                    {
                        skill_player.PlaySkill(playercontroller.LongSword);
                        skill_player.gameObject.transform.position = new Vector2(SelectionController.instance.GameObjectWasSelected.transform.position.x, SelectionController.instance.GameObjectWasSelected.transform.position.y + 0.3f);

                    }

                }
            }
            
        }
        else
        {
            if (playercontroller.playermovement.isstatus_move == true)
            {
                if (playercontroller.playermovement.isMoveLeft == true)
                {
                    ChangeState(PLAYER_MOVE_LEFT);
                    // hat
                    hat_equipment.StartLeft(playercontroller.Hat_Eqiupment);

                    //shirt
                    shirt_equipment.StartLeft(playercontroller.Shirt_Equipment);

                    //trousers
                    trousers_equipment.StartLeft(playercontroller.Trouser_Eqiupment);
                }
                else if (playercontroller.playermovement.isMoveRight == true)
                {
                    ChangeState(PLAYER_MOVE_RIGHT);
                    // hat
                    hat_equipment.StartRight(playercontroller.Hat_Eqiupment);

                    //shirt
                    shirt_equipment.StartRight(playercontroller.Shirt_Equipment);

                    //trousers
                    trousers_equipment.StartRight(playercontroller.Trouser_Eqiupment);
                }
                else if (playercontroller.playermovement.isMoveDown == true)
                {
                    ChangeState(PLAYER_MOVE_DOWN);
                    // hat
                    hat_equipment.StartDown(playercontroller.Hat_Eqiupment);

                    //shirt
                    shirt_equipment.StartDown(playercontroller.Shirt_Equipment);

                    //trousers
                    trousers_equipment.StartDown(playercontroller.Trouser_Eqiupment);
                }
                else if (playercontroller.playermovement.isMoveUp == true)
                {
                    ChangeState(PLAYER_MOVE_UP);
                    // hat
                    hat_equipment.StartUp(playercontroller.Hat_Eqiupment);

                    //shirt
                    shirt_equipment.StartUp(playercontroller.Shirt_Equipment);

                    //trousers
                    trousers_equipment.StartUp(playercontroller.Trouser_Eqiupment);
                }
            }
            else
            {

                if (playercontroller.playermovement.isIDLE_Down == true)
                {
                    ChangeState(PLAYER_IDLE_DOWN);
                    //hat
                    hat_equipment.StartIDLEDown(playercontroller.Hat_Eqiupment);


                    //shirt
                    shirt_equipment.StartIDLEDown(playercontroller.Shirt_Equipment);


                    //trousers
                    trousers_equipment.StartIDLEDown(playercontroller.Trouser_Eqiupment);

                }
                else if (playercontroller.playermovement.isIDLE_Left == true)
                {
                    ChangeState(PLAYER_IDLE_LEFT);
                    //hat
                    hat_equipment.StartIDLELeft(playercontroller.Hat_Eqiupment);


                    //shirt
                    shirt_equipment.StartIDLELeft(playercontroller.Shirt_Equipment);


                    //trousers
                    trousers_equipment.StartIDLELeft(playercontroller.Trouser_Eqiupment);

                }
                else if (playercontroller.playermovement.isIDLE_Right == true)
                {
                    ChangeState(PLAYER_IDLE_RIGHT);
                    //hat
                    hat_equipment.StartIDLERight(playercontroller.Hat_Eqiupment);


                    //shirt
                    shirt_equipment.StartIDLERight(playercontroller.Shirt_Equipment);


                    //trousers
                    trousers_equipment.StartIDLERight(playercontroller.Trouser_Eqiupment);

                }
                else if (playercontroller.playermovement.isIDLE_Up == true)
                {
                    ChangeState(PLAYER_IDLE_UP);
                    //hat
                    hat_equipment.StartIDLEUp(playercontroller.Hat_Eqiupment);


                    //shirt
                    shirt_equipment.StartIDLEUp(playercontroller.Shirt_Equipment);


                    //trousers
                    trousers_equipment.StartIDLEUp(playercontroller.Trouser_Eqiupment);

                }
            }
        }
    }

    internal void ChangeState(string newState)
    {
        if (newState != currentState)
        {
            playercontroller.animator.Play(newState);
            currentState = newState;
        }

    }

    void AttackComplete()
    {
        playercontroller.playergetinputvalue.keypress = "";
        playercontroller.playergetinputvalue.isSlash = false;
        if (playercontroller.LongSword == "LongSword")
        {
            longSword_weapon.Stop(playercontroller.LongSword);
        }
        else
        {
            skill_player.StopSkill();
        }    
        playercontroller.playergetinputvalue.countattack_press = 0;
    }
}
