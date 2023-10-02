using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5.0f;

    private Vector3 offset;

    void Start()
    {

        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        if (target == null)
        {

            return;
        }


        Vector3 desiredPosition = target.position + offset;


        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
