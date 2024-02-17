using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGrounded = false;
    public Rigidbody2D rb;
    public Vector3 jump;
    public Vector3 move;
    public float moveDir;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0f, 10f, 0f);
        move = new Vector3(0f,0f,0f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded=true;
        Debug.Log("True!");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            moveDir=0.05f;
            move.x=moveDir;
            gameObject.transform.Translate(move);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            moveDir=0.05f;
            move.x=-moveDir;
            gameObject.transform.Translate(move);
        }
    }   
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space)&&isGrounded)
        {
            rb.AddForce(jump, ForceMode2D.Impulse);
            isGrounded=false;
        }
    }
}
