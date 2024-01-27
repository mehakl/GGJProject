using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class CameraMoveScript : MonoBehaviour
{
    public GameObject CamTarget;
    private Vector3 startpos;
    [SerializeField] Vector3 finishpos;
    private Vector3 startrot;
    [SerializeField] Vector3 finishrot;
    public float Speed = 50f;

    bool canMoveCam;
    public Transform target; // Reference to the target object (e.g., player)
    public Vector3 offset = new Vector3(0, 5, -10); // Offset from the target
    public float smoothSpeed = 0.125f; // Smoothing factor

    private void LateUpdate()
    {
        if (canMoveCam)
        {
            moveCam();
           
        }
    }
    public void moveCam()
    {
        canMoveCam = true;
        Vector3 desiredPosition = target.position;


        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);


        transform.position = smoothedPosition;


        transform.LookAt(target);
    }
}
