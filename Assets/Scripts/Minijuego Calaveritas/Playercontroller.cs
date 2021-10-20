using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    public float Speed;
    public int life = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveByHover();


    }

    void moveByHover()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);// get the hover position
        direction = (mousePosition - transform.position).normalized; // direction from walking to point position 
        rb.velocity = new Vector2(direction.x * Speed, 0); // rigibody gets the velocity by multiply the speed


    }


}
