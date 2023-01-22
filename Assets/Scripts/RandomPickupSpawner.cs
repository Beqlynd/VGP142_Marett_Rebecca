using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPickupSpawner : MonoBehaviour
{
    public GameObject[] Pickups;

    int spawnRate = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {     
        if (spawnRate < 5)
        {
            int randomIndex = Random.Range(0, Pickups.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-193, 201), 52, Random.Range(-284, 85));

            Instantiate(Pickups[randomIndex], randomSpawnPosition, Quaternion.identity);

            spawnRate++;
        }
    }
}
