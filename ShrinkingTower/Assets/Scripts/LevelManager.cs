using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms, willDestroyedPlatforms, collectibles;

    [SerializeField] private GameObject lastPlatform, player;
    private int randomNumber, percent30number;

    public int platformsDistance, collectiblesDistance;
    public int platformInstaniteCount;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        willDestroyedPlatforms = new GameObject[platformInstaniteCount];
        lastPlatform = player;
    }

    void Start()
    {
        RandomPlatformInstantiate();

    }


    void Update()
    {
        if (player.transform.position.y - lastPlatform.transform.position.y > 2)
        {
            RandomPlatformInstantiate();


        }

    }
    private void RandomPlatformInstantiate()
    {
        if (willDestroyedPlatforms != null)
        {
            for (int i = 0; i < platformInstaniteCount; i++)
            {
                Destroy(willDestroyedPlatforms[i]);
            }
        }
        for (int i = 0; i < platformInstaniteCount; i++)
        {
            percent30number = Random.Range(0, 10);

            randomNumber = Random.Range(0, platforms.Length);
            lastPlatform = Instantiate(platforms[randomNumber], new Vector3(0, lastPlatform.transform.position.y + platformsDistance, 0), Quaternion.identity);
            if (percent30number < 3)
            {
                randomNumber = Random.Range(0, platforms.Length);
                Instantiate(collectibles[randomNumber], new Vector3(0, lastPlatform.transform.position.y + collectiblesDistance, 0), Quaternion.identity);
            }




        }

    }
}




