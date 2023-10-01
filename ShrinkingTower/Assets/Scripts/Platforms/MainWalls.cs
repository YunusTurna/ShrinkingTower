using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWalls : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public float approachSpeed = 10f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = new Vector2(transform.position.x , player.transform.position.y);
      transform.position = Vector2.MoveTowards(transform.position , player.transform.position, approachSpeed * Time.deltaTime);
    }
}
