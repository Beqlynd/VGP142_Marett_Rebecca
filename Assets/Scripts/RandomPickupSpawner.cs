using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.IO;

public class RandomPickupSpawner : MonoBehaviour
{
    int spawnRateOne = 0;
    int spawnRateTwo = 0;
    int spawnRateThree = 0;
    int spawnRateFour = 0;
    int spawnRateFive = 0;


    public GameObject[] Pickups;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
        if (spawnRateOne < 3)
        {
            int spawnAreaOne;

            try
            {
                int randomIndex = UnityEngine.Random.Range(0, Pickups.Length);
                Vector3 randomSpawnPosition = new Vector3(UnityEngine.Random.Range(141, 178), 51, UnityEngine.Random.Range(53, 74));

                Instantiate(Pickups[randomIndex], randomSpawnPosition, Quaternion.identity);

                spawnRateOne++;
            }
            catch (Exception e)
            {
                Debug.LogException(e, this);
            }
            throw new ArgumentException("Spawn area instantiated", nameof(spawnAreaOne));
        }

        if (spawnRateTwo < 3)
        {
            int spawnAreaTwo;

            try
            {
                int randomIndex = UnityEngine.Random.Range(0, Pickups.Length);
                Vector3 randomSpawnPosition = new Vector3(UnityEngine.Random.Range(-56, -5), 51, UnityEngine.Random.Range(-47, 2));

                Instantiate(Pickups[randomIndex], randomSpawnPosition, Quaternion.identity);

                spawnRateTwo++;
            }
            catch (Exception e)
            {
                Debug.LogException(e, this);
            }
            throw new ArgumentException("Spawn area instantiated", nameof(spawnAreaTwo));
        }

        if (spawnRateThree < 3)
        {
            int spawnAreaThree;

            try
            {
                int randomIndex = UnityEngine.Random.Range(0, Pickups.Length);
                Vector3 randomSpawnPosition = new Vector3(UnityEngine.Random.Range(-163, -111), 51, UnityEngine.Random.Range(-116, -79));

                Instantiate(Pickups[randomIndex], randomSpawnPosition, Quaternion.identity);

                spawnRateThree++;
            }
            catch (Exception e)
            {
                Debug.LogException(e, this);
            }
            throw new ArgumentException("Spawn area instantiated", nameof(spawnAreaThree));
        }

        if (spawnRateFour < 3)
        {
            int spawnAreaFour;

            try
            {
                int randomIndex = UnityEngine.Random.Range(0, Pickups.Length);
                Vector3 randomSpawnPosition = new Vector3(UnityEngine.Random.Range(-111, -62), 51, UnityEngine.Random.Range(-250, -195));

                Instantiate(Pickups[randomIndex], randomSpawnPosition, Quaternion.identity);

                spawnRateFour++;
            }
            catch (Exception e)
            {
                Debug.LogException(e, this);
            }
            throw new ArgumentException("Spawn area instantiated", nameof(spawnAreaFour));
        }

        if (spawnRateFive < 3)
        {
            int spawnAreaFive;

            try
            {
                int randomIndex = UnityEngine.Random.Range(0, Pickups.Length);
                Vector3 randomSpawnPosition = new Vector3(UnityEngine.Random.Range(81, 104), 76, UnityEngine.Random.Range(-258, -236));

                Instantiate(Pickups[randomIndex], randomSpawnPosition, Quaternion.identity);

                spawnRateFive++;
            }
            catch (Exception e)
            {
                Debug.LogException(e, this);
            }
            throw new ArgumentException("Spawn area instantiated", nameof(spawnAreaFive));
        }
    }
}
