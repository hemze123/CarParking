using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{

    public FloatingJoystick Joystick;
    private Rigidbody rb;
    [SerializeField] private int Speed = 10;
    private float moveH, moveV;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        moveH = Joystick.Horizontal;
        moveV = Joystick.Vertical;
        Vector3 dir = new Vector3(moveH, 0, moveV);
        rb.velocity = new Vector3(moveH * Speed, rb.velocity.y, moveV * Speed);
        if(dir != Vector3.zero)
        {
            transform.LookAt(transform.position + dir);
        }
    }
}
