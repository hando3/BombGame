using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollwCamera : MonoBehaviour
{
    public Transform target;
    public float dist = 10f;
    public float height = 5f;
    public float smoothRotate = 5.0f;

    void LateUpdate()
    {
        float currYAngle = Mathf.LerpAngle(transform.eulerAngles.y,
                             target.eulerAngles.y, smoothRotate * Time.deltaTime);
        Quaternion rot = Quaternion.Euler(0, currYAngle, 0);
        transform.position = target.position - (rot * Vector3.forward * dist) +
                               (Vector3.up * height);
        transform.LookAt(target);
    }
}