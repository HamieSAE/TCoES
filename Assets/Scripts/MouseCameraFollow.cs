using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraFollow : MonoBehaviour
{
    public Transform ball;       // Reference to the ball's transform
    public Vector3 offset;       // Offset position from the ball
    public float sensitivity = 5f; // Mouse sensitivity
    public float distance = 10f;   // Distance from the ball

    private float yaw = 0f;
    private float pitch = 0f;

    void Start()
    {
        // Initialize the offset based on the initial position
        offset = new Vector3(0, 0, -distance);
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Get mouse inputs
        yaw += Input.GetAxis("Mouse X") * sensitivity;
        pitch -= Input.GetAxis("Mouse Y") * sensitivity;

        // Clamp the pitch value to avoid flipping
        pitch = Mathf.Clamp(pitch, -89f, 89f);
    }

    void LateUpdate()
    {
        // Calculate the rotation
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);

        // Calculate the camera position based on the ball's position, rotation, and offset
        Vector3 position = ball.position + rotation * offset;

        // Set the camera's position and rotation
        transform.position = position;
        transform.LookAt(ball.position);
    }
}
