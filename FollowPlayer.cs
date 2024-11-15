using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float camChange;
    private Vector3 offset1= new Vector3(0,6,-9);
    private Vector3 offset2= new Vector3(0.6f,2.865f,2.577f);
    private bool toggleState = false;
    private bool axisInUse=false;

    public string playerId;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation = player.transform.rotation;
        camChange=Input.GetAxis("Fire" + playerId);

        if (camChange != 0 && !axisInUse)
        {
            toggleState = !toggleState;
            if (toggleState)
            {
                transform.position = player.transform.position + offset2;
                
               
            }
            else
            {
                transform.position = player.transform.position + offset1;
             
            }
            axisInUse = true;
        }
        if (camChange == 0)
        {
            axisInUse = false;
            if (toggleState)
            {
                transform.position = player.transform.position + offset2;
            }
            else
            {
                transform.position = player.transform.position + offset1;
            }

        }

    }
}

