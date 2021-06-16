using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothing;

    private Vector3 targetPosition;
    
    
    void LateUpdate()
    {
        targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

        if (transform.position != target.position)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}
