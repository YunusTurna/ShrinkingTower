using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWalls : MonoBehaviour
{
    [SerializeField] private GoBackMainWall gb;
    [SerializeField] private GameObject player;
    public float approachSpeed = 10f;
    public float turnBackSpeed = 10f;
    
    private Vector3 initialPosition; 

    private void Awake()
    {
        
        initialPosition = this.gameObject.transform.position; 
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (gb.goBack == false)
        {
            transform.position = new Vector2(transform.position.x, player.transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, approachSpeed * Time.deltaTime);
        }
        else if (gb.goBack == true)
        {
            transform.position = new Vector2(transform.position.x, player.transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, initialPosition, turnBackSpeed * Time.deltaTime);
        }
        if(Mathf.Abs(this.gameObject.transform.position.x - initialPosition.x) < 0.5 )
        {
            gb.goBack = false;
        }
    }
}
