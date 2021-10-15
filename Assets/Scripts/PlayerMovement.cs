using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 5.0f;
    public Rigidbody2D myRigidBody2D;

    Vector2 movement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //Movement

        myRigidBody2D.MovePosition(myRigidBody2D.position + movement * moveSpeed * Time.fixedDeltaTime); 
    }
}
