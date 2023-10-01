using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    private Vector3 startPoint;
    private Vector3 endPoint;
    [SerializeField] private float offSet = 1f;
    public float speed = 2.0f;

    void Start()
    {
        // Başlangıç ve bitiş noktalarını ayarlayın
        startPoint = transform.position + new Vector3(-offSet, 0.0f, 0.0f);
        endPoint = transform.position + new Vector3(offSet, 0.0f, 0.0f);
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, endPoint, step);

        if (transform.position == endPoint)
        {
            // Eğer nesne bitiş noktasına ulaştıysa, başlangıç ve bitiş noktalarını değiştirin.
            Vector3 temp = startPoint;
            startPoint = endPoint;
            endPoint = temp;
        }
    }
}
