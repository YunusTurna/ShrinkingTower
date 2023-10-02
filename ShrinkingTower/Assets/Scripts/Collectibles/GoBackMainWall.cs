using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackMainWall : MonoBehaviour
{
    public static bool goBack = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            goBack = true;
        }
        
    }
}

