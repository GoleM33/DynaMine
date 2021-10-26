
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform traget;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void FixedUpdate()
    {
        Vector3 desiredPosition = traget.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = desiredPosition;

       
    }


    
}
