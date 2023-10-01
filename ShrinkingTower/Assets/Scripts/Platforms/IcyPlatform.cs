using UnityEngine;

public class IcyPlatform : MonoBehaviour
{
    [SerializeField] private float speedMultiplier = 2.0f; // Hız çarpanı

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Karakterin hızını iki katına çıkar
        if (other.gameObject.CompareTag("Player")) // Karakteri tanımlamak için bir etiket (tag) kullanılabilir.
        {
            PlayerMovement pm = other.gameObject.GetComponent<PlayerMovement>();
            if (pm != null)
            {
                pm.moveSpeed *= speedMultiplier;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        // Temas sona erdiğinde hız çarpanını geri al
        if (other.gameObject.CompareTag("Player")) // Karakteri tanımlamak için bir etiket (tag) kullanılabilir.
        {
            PlayerMovement pm = other.gameObject.GetComponent<PlayerMovement>();
            if (pm != null)
            {
                pm.moveSpeed /= speedMultiplier;
            }
        }
    }
}
