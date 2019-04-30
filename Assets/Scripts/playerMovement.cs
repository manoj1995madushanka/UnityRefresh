using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1500f;
    public float sideWaysForce = 200f;
    public bool leftSideWaysForce =false;
    public bool rightSideWaysForce = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
        //rb.useGravity = false;
    }

    // use update method for get user inputs because it is speeder than the update method
    /* void Update()
    {
        if(Input.GetKey("a")){
            leftSideWaysForce= true;
        }
        if(Input.GetKey("d")){
            rightSideWaysForce = true;
        }
    }*/

    // Update is called once per frame
    // if you use rigitbody or like somthing change Update to FixedUpdate
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        if(Input.GetKey("a")){
            rb.AddForce(-sideWaysForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("d")){
            rb.AddForce(sideWaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
    }
}
