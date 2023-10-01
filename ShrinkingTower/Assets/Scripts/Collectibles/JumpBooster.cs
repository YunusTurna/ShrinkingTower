using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBooster : MonoBehaviour
{
    [SerializeField] private PlayerMovement pm;
    [SerializeField] private float jumpCoefficent =2;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(JumpBoosterMethod());
        }
    }
    IEnumerator JumpBoosterMethod()
    {
        pm.jumpForce *=jumpCoefficent;
        yield return new WaitForSeconds(3);
        pm.jumpForce /=jumpCoefficent;

    }
}
