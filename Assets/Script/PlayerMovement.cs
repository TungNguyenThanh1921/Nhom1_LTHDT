using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    PlayerController playercontroller;
    internal bool isMoveLeft;
    internal bool isMoveRight;
    internal bool isMoveUp;
    internal bool isMoveDown;
    internal bool isIDLE_Down;
    internal bool isIDLE_Left;
    internal bool isIDLE_Right;
    internal bool isIDLE_Up;
    internal bool isstatus_move;
    internal string current_derection = "";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playercontroller.playergetinputvalue.isSlash == false)
        {
            if (playercontroller.movementinput != Vector2.zero)
            {
                isstatus_move = true;
                
                bool flag = TryMove(playercontroller.movementinput);

                if (!flag)
                {
                    flag = TryMove(new Vector2(playercontroller.movementinput.x, 0));
                }
                if (!flag)
                {
                    flag = TryMove(new Vector2(0, playercontroller.movementinput.y));
                }

                if (flag)
                {
                    if (playercontroller.movementinput.x < 0)
                    {
                        isMoveLeft = true;
                        isMoveRight = false;
                        isMoveDown = false;
                        isMoveUp = false;
                        current_derection = "left";

                    }
                    else if (playercontroller.movementinput.x > 0)
                    {
                        isMoveRight = true;
                        isMoveLeft = false;
                        isMoveDown = false;
                        isMoveUp = false;
                        current_derection = "right";
                    }

                    else if (playercontroller.movementinput.y < 0)
                    {
                        isMoveDown = true;
                        isMoveUp = false;
                        isMoveLeft = false;
                        isMoveRight = false;
                        current_derection = "down";
                    }
                    else if (playercontroller.movementinput.y > 0)
                    {
                        isMoveUp = true;
                        isMoveDown = false;
                        isMoveLeft = false;
                        isMoveRight = false;
                        current_derection = "up";
                    }
                }
            }
            else
            {
                isstatus_move = false;

                if (current_derection == "down")
                {
                    isIDLE_Down = true;
                    isMoveDown = false;
                    isIDLE_Left = false;
                    isIDLE_Right = false;
                    isIDLE_Up = false;
                }
                else if (current_derection == "left")
                {
                    isIDLE_Left = true;
                    isMoveLeft = false;
                    isIDLE_Right = false;
                    isIDLE_Up = false;
                    isIDLE_Down = false;
                }
                else if (current_derection == "right")
                {
                    isIDLE_Right = true;
                    isMoveRight = false;
                    isIDLE_Left = false;
                    isIDLE_Up = false;
                    isIDLE_Down = false;

                }
                else if (current_derection == "up")
                {
                    isIDLE_Up = true;
                    isMoveUp = false;
                    isIDLE_Left = false;
                    isIDLE_Down = false;
                    isIDLE_Right = false;
                }

            }
        }

    }
  
    private bool TryMove(Vector2 derection)
    {
        if (derection != Vector2.zero)
        {
            int count = playercontroller.rb.Cast(
                    derection, // X and Y values between -1 and 1 that represent the direction from the body to look for collisions
                    playercontroller.movementfilter, // The settings that determine where a collision can occur on such as layers to collide with
                   playercontroller.catcolliisons, // List of collisions to store the found collisions into after the Cast is finished
                   playercontroller.movespeed * Time.fixedDeltaTime + playercontroller.collisionoffset); // The amount to cast equal to the movement plus an offset

            if (count == 0)
            {
                playercontroller.rb.MovePosition(playercontroller.rb.position + derection * playercontroller.movespeed * Time.fixedDeltaTime);
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            // can't move if there's no derection to move in
            return false;
        }

    }


}
