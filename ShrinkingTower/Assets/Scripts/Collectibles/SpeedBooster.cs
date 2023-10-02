using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    [SerializeField] private PlayerMovement pm;
    [SerializeField] private float speedCoefficent =2;
    private void Start() {
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(SpeedBoosterMethod());
        }
    }
    IEnumerator SpeedBoosterMethod()
    {
        pm.moveSpeed *=speedCoefficent;
        yield return new WaitForSeconds(3);
        pm.moveSpeed /=speedCoefficent;

    }
}
