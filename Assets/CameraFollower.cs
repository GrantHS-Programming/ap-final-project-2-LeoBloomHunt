using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothSpeed = .125f;
    void LateUpdate()
    {
        transform.position = target.position;
    }
}
