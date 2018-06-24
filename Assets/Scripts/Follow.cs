using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{

    public float mouseSpeed = 3;
    public Transform player;
    public Camera yourCam;

    private void Update()
    {
        float X = Input.GetAxis("Mouse X") * mouseSpeed;
        float Y = Input.GetAxis("Mouse Y") * mouseSpeed;

        player.Rotate(0, X, 0); // Player rotates on Y axis, your Cam is child, then rotates too


        // To scurity check to not rotate 360º 
        if (yourCam.transform.eulerAngles.x + (-Y) > 80 && yourCam.transform.eulerAngles.x + (-Y) < 280)
        { }
        else
        {

            yourCam.transform.RotateAround(player.position, yourCam.transform.right, -Y);
        }
    }


}