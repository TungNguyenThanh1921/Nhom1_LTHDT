using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetInputValue : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    PlayerController playercontrol;

    internal string keypress;
    internal bool isSlash = false;

    internal int countattack_press = 0;
    float currenttime = 0f;
    float timebetweenspaws = 0.5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currenttime += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (currenttime > timebetweenspaws)
            {
                keypress = "Q";
                isSlash = true;
                currenttime = 0;
                playercontrol.LongSword = "LongSword";

            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currenttime > timebetweenspaws)
            {
                if (Player.instance.MPCurrent >= 10)
                {
                    isSlash = true;
                    currenttime = 0;
                    playercontrol.LongSword = "Thunder";
                    Player.instance.MPCurrent -= 10;
                }
                

            }
    

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (currenttime > timebetweenspaws)
            {
                if (Player.instance.MPCurrent >= 10)
                {
                    isSlash = true;
                    currenttime = 0;
                    playercontrol.LongSword = "BlueFire";
                    Player.instance.MPCurrent -= 10;
                }

           

            }

        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (currenttime > timebetweenspaws)
            {
                if (Player.instance.MPCurrent >= 10)
                {

                    isSlash = true;
                    currenttime = 0;
                    playercontrol.LongSword = "RedFire";
                    Player.instance.MPCurrent -= 10;
                }


            }
         
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (currenttime > timebetweenspaws)
            {
                if (Player.instance.MPCurrent >= 10)
                {

                    isSlash = true;
                    currenttime = 0;
                    playercontrol.LongSword = "Wind";
                    Player.instance.MPCurrent -= 10;
                }


            }

        }


     
    }

}
