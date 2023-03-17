using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform targetToFollow;
    public GameObject player;
    public float timeOffset;
    

    public Vector2 posOffset;
    private Vector3 velocity;

    public float leftLimit;
    public float rightLimit;
    public float bottomLimit;
    public float topLimit;
    
    void Start()
    {
        
    }
    private void OnLevelWasLoaded(int level)
    {
        FindStartPosition();
      
        
    }
    void FindStartPosition()
    {
        transform.position = GameObject.FindWithTag("StartPosition").transform.position;
        
    }
    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player");  //PlayerController.instance.gameObject;
        targetToFollow = GameObject.FindWithTag("Player").transform;//PlayerController.instance.gameObject.transform;    
        //camera current position
        Vector3 startpos = transform.position;
        //player current position
        Vector3 endpos = player.transform.position;

        endpos.x += posOffset.x;
        endpos.y += posOffset.y;
        endpos.z = -10;

        //smoothly move the camera towards the player position
        transform.position = Vector3.Lerp(startpos, endpos, timeOffset* Time.deltaTime);
    }
   
}
