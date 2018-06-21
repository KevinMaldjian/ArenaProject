using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController characterController;

    public float Speed = 5.0f;

    public float RotationSpeed = 240.0f;
    private float Gravity = 20.0f;
    private float jumpForce = 8f;
    public bool canMove;
    private float verticalVelocity = 0f;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        canMove = true; 
    }
    void Update()
    {
        if (characterController.isGrounded && canMove)
        {
            if(Input.GetButton("Jump"))
            {
                verticalVelocity = jumpForce;
            }
            else
            {
                verticalVelocity = 0;
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Speed, Space.Self);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * Speed, Space.Self);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * Speed, Space.Self);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * Time.deltaTime * Speed, Space.Self);
            }
        }
        else
        {
            verticalVelocity -= Gravity * Time.deltaTime;
        }
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal") * Speed, verticalVelocity, Input.GetAxis("Vertical") * Speed);
        moveDirection = transform.TransformDirection(moveDirection);
        characterController.Move(moveDirection * Time.deltaTime);
    }
}