using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    public Transform target;
    public Vector3 ofsset;
    [Range(1,10)]
    public float smoothFactor;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Follow();
    }
    void Follow()
    {
        Vector3 targetPosition = target.position + ofsset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition,smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothedPosition;
    }
}
