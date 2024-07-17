using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ball;       // Reference to the ball's transform
    public Vector3 offset;       // Offset position from the ball
    public float smoothSpeed = 0.125f;  // Smoothing speed for the camera

    void Start()
    {
        // Calculate the initial offset from the ball
        offset = transform.position - ball.position;
    }

    void LateUpdate()
    {
        // Update the camera's position based on the ball's position but keep the offset
        Vector3 targetPosition = ball.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}

