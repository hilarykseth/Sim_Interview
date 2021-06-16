using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothing = 2f;

    private Vector3 targetPosition;
    
    
    void FixedUpdate()
    {
        targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

        if (transform.position != target.position)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}
