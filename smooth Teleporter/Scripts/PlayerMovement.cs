using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 100f;
    public float drag = 6f;

    Vector3 moveDirection;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");

        moveDirection = transform.forward * verticalMove + transform.right * horizontalMove;

        rb.drag = drag;
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Acceleration);
    }
}
