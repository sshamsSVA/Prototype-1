using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Transform playerPos;
    public Vector3 offset = new Vector3(0, 5, -15);
    PlayerController playerController;
    public float camTurnSpeed = 50.0f;
    float pCf;

    float minDist = 2;

    

    // Start is called before the first frame update
    void Start()
    {
        playerController = player.GetComponent<PlayerController>();
       pCf = playerController.horizontalInput;
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
      transform.position = player.transform.position + offset;

        transform.RotateAround(player.transform.position, Vector3.up, playerController.horizontalInput * Time.deltaTime * camTurnSpeed);
        
        // float dist = Vector3.Distance(player.transform.position, transform.position);

       // Debug.Log(dist);
    }
}


/* Testing Code */

/* 

    
    bool pressed = false;

    public Vector3 offsetRotation = new Vector3(0, 0, 0);

    Debug.Log(pCf);



        if ( pCf> 0f || pCf < 0f) 
        {
            pressed = true;

            offset = new Vector3(-300, 0, -120);
        }
        pressed = false;
 */

