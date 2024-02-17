using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGrounded = false;
    public Rigidbody rb;
    public Vector3 jump;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f, 2f, 0f);
    }
    void OnCollisionEnter(Collision collision)
    {
        isGrounded=true;
        Debug.Log("True!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space)&&isGrounded)
        {
            rb.AddForce(jump, ForceMode.Impulse);
            isGrounded=false;
        }
    }
}
