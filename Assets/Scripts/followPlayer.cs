using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Vector3 offest;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // print player location to the console
        Debug.Log(player.position);
        // now set player position to the camera
        transform.position = player.position +offest; 
    }
}
