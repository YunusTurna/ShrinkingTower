using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterPlatform : MonoBehaviour
{
    public float boostPower = 10f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * boostPower * Time.deltaTime, ForceMode2D.Impulse);
            Debug.Log("Caslltoi");
        }
    }
}
