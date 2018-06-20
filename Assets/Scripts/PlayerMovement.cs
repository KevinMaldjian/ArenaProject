using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController _characterController;

    public float Speed = 5.0f;

    public float RotationSpeed = 240.0f;

    private float Gravity = 20.0f;

    private Vector3 _moveDir = Vector3.zero;

    private float jumpForce = 8f;

    public bool canMove;

    // Use this for initialization
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        canMove = true; 
    }

    // Update is called once per frame
    void Update()
    {
        // Get Input for axis
        //float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float mouseInput = Input.GetAxis("Mouse X");
        //float fH = h + mouseInput;


        // Calculate the forward vector
        Vector3 camForward_Dir = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 move = v * camForward_Dir + mouseInput * Camera.main.transform.right;

        if (move.magnitude > 1f) move.Normalize();

        // Calculate the rotation for the player
        move = transform.InverseTransformDirection(move);

        // Get Euler angles
        float turnAmount = Mathf.Atan2(move.x, move.z);
        //float mouseInput = Input.GetAxis("Mouse X");
       // Vector3 lookhere = new Vector3(0, mouseInput, 0);

        transform.Rotate(0, turnAmount * RotationSpeed * Time.deltaTime, 0);

        if (_characterController.isGrounded && canMove)
        {
           // _animator.SetBool("run", move.magnitude > 0);

            _moveDir = transform.forward * move.magnitude;

            _moveDir *= Speed;

            if (Input.GetButtonDown("Jump"))
            {
                _moveDir.y = jumpForce;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * Speed, Space.Self);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * Speed, Space.Self);
            }

            //if (Input.GetKey(KeyCode.S))
            //{
            //    transform.Translate(Vector3.back * Time.deltaTime * Speed, Space.Self);
            //}
        }

        _moveDir.y -= Gravity * Time.deltaTime;

        _characterController.Move(_moveDir * Time.deltaTime);
    }

    float AngleBetweenPoints(Vector2 a, Vector2 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}