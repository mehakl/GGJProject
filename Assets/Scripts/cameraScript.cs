using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Transform target; // Reference to the target object (e.g., player)
    public Vector3 offset = new Vector3(0, 5, -10); // Offset from the target
    public float smoothSpeed = 0.125f; // Smoothing factor

    private void LateUpdate()
    {
        // Calculate the desired camera position
        Vector3 desiredPosition = target.position;

        // Smoothly move the camera towards the desired position using Lerp
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera's position
        transform.position = smoothedPosition;

        // Make the camera look at the target
        transform.LookAt(target);
    }
}
