using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPlatform : MonoBehaviour
{
    public float patrolSpeed = 5f;
    private Vector3 initialPosition; 

    private void Awake()
    {
        
        initialPosition = this.gameObject.transform.position; 
    }
}
