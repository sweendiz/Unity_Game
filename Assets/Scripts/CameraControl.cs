using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class CameraControl : MonoBehaviour
{
    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    public Transform lookAt;
    public Transform camTransform;
    public float distance = 10.0f;

    private float currentX = 0.0f;
    private float currentY = 45.0f;
    private float sensitivityX = 8.0f;   //editable by player
    private float sensitivityY = 5.0f;   //editable by player

    private void Start()
    {
        camTransform = transform;
    }

    private void Update()
    {
        if (Input.GetMouseButton(2))
        {
            currentX += Input.GetAxis("Mouse X") * sensitivityX;
            currentY += Input.GetAxis("Mouse Y") * sensitivityY;

            currentY = (Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX));
        }
        if (Input.GetKey("up")) {
            Debug.Log("Up arrow");
        }
        if (Input.GetKey("down"))
        {
            Debug.Log("Down arrow");
        }
        if (Input.GetKey("right"))
        {
            Debug.Log("Right arrow");
        }
        if (Input.GetKey("left"))
        {
            Debug.Log("left arrow");
        }

    }

    private void LateUpdate()
    {

        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}
