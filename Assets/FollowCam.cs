using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] GameObject target;

    Vector3 positionOffset;

    void Start()
    {
        positionOffset = target.transform.position - transform.position;
    }

    void Update()
    {
        if (target == null)
            return;

        Vector3 newPosition;
        newPosition = target.transform.position - positionOffset;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
    }
}
