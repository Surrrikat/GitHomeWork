using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionRotation : MonoBehaviour
{
    public Transform LookAt;
    public Vector3 RotationVelocity;
    public Vector3 Rotation;

    void Update()
    {
        Vector3 forward = (LookAt.position - transform.position).normalized;
        forward = Quaternion.Euler(Rotation) * forward;
        
        transform.rotation = Quaternion.LookRotation(forward);

    }
}
