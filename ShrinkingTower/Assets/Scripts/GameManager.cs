using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms , willDestroyedPlatforms;
    
    [SerializeField] private GameObject lastPlatform , player;
    private int randomNumber ;
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
        if(player.transform.position.y - lastPlatform.transform.position.y > 2)
        {
            RandomPlatformInstantiate();

        }
        
    }
    private void RandomPlatformInstantiate()
    {
        if(willDestroyedPlatforms != null)
        {
            for (int i = 0; i < platformInstaniteCount; i++)
            {
                Destroy(willDestroyedPlatforms[i]);
            }
        }
        for (int i = 0; i < platformInstaniteCount; i++)
        {
            
            randomNumber = Random.Range(0 , platforms.Length);
            lastPlatform = Instantiate(platforms[randomNumber] , new Vector3(0,lastPlatform.transform.position.y + 5, 0), Quaternion.identity );
            willDestroyedPlatforms[i] = lastPlatform;
            
            
            
        }


    }
}
