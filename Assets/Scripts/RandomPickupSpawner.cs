using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.IO;

public class RandomPickupSpawner : MonoBehaviour
{
    public GameObject[] Pickups;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int spawnRate = 0;
        try
        {
            
            if (spawnRate < 5 && spawnRate !> 5)
            {
                int randomIndex = UnityEngine.Random.Range(0, Pickups.Length);
                Vector3 randomSpawnPosition = new Vector3(UnityEngine.Random.Range(-193, 201), 52, UnityEngine.Random.Range(-13, 85));

                Instantiate(Pickups[randomIndex], randomSpawnPosition, Quaternion.identity);

                spawnRate++;
            }
        }
        catch(FileNotFoundException e)
        {
            Console.WriteLine($"[Data File Missing { e }");
            throw new FileNotFoundException(@"[Data.txt not in c:\temp directory]", e);
        }
        finally
        {
            if (spawnRate != null)
                spawnRate = 0;
        }

    }
}
