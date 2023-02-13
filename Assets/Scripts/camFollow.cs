using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    public Transform p1;
    public Vector3 camOffset;
    public float smoothFactor = .5f;
    public bool lookAtTarget = false;

    void Start()
    {
        p1 = GameObject.Find("Player").GetComponent<Transform>();
        camOffset = transform.position - p1.transform.position;
    }

    void LateUpdate()
    {
        Vector3 newPos = p1.transform.position + camOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

        if (lookAtTarget )
        {
            transform.LookAt( p1 );
        }
    }
}
