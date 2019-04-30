using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement playermovement;
    // public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo)
    {
     // Debug.Log("enter to the collision : "+ collisionInfo.collider.name);   
        if(collisionInfo.collider.tag == "Obstacle") {
            Debug.Log("We touch enemy body");
            playermovement.enabled = false;
            FindObjectOfType<GameManager>().endGame();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
