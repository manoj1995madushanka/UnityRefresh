using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
        //rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,1500 * Time.deltaTime);
    }
}
