using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    internal PlayerMovement playermovement;

    [SerializeField]
    internal PlayerAnimation playeranimation;

    [SerializeField]
    internal PlayerGetInputValue playergetinputvalue;

    
    internal Vector2 movementinput;
    internal Rigidbody2D rb;
    internal float movespeed = 1f;
    internal float collisionoffset = 0.05f;

    internal ContactFilter2D movementfilter;
    internal List<RaycastHit2D> catcolliisons = new List<RaycastHit2D>();
    internal Animator animator;

    internal string Hat_Eqiupment = "NonGiapSat";
    internal string Shirt_Equipment = "AoGiapSat";
    internal string Trouser_Eqiupment = "QuanGiapSat";
    internal string LongSword = "LongSword";

    internal float attackdelay = 0.18f;
    SpriteRenderer spriterender;

    
    private GameObject[] players;
   // PlayerInput input;

    void Start()
    {
     
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriterender = GetComponent<SpriteRenderer>();

        DontDestroyOnLoad(gameObject);
     
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
        
    }
   

    private void OnLevelWasLoaded(int level)
    {
        FindStartPosition();
        players = GameObject.FindGameObjectsWithTag("Player");
        if (players.Length > 1)
        {
            Destroy(players[1]);
        }
    }
     void FindStartPosition()
    {
        transform.position = GameObject.FindWithTag("StartPosition").transform.position;
    }
    void OnMove(InputValue movementvalue)
    {
        movementinput = movementvalue.Get<Vector2>();
    }


}
