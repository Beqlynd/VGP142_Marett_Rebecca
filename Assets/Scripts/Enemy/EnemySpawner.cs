using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] Enemies;
    public Transform player;
    public float spawnDistance = 10f;
    public float spawnInterval = 60f;

    private float timeSinceLastSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timeSinceLastSpawn = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            timeSinceLastSpawn = 0f;

            Vector3 randomOffset = Random.insideUnitSphere * spawnDistance;
            Vector3 spawnPosition = player.position + randomOffset;
            spawnPosition.y = transform.position.y;

            NavMeshHit hit;
            if (NavMesh.SamplePosition(spawnPosition, out hit, 5f, NavMesh.AllAreas))
            {
                int randomIndex = Random.Range(0, Enemies.Length);
                Instantiate(Enemies[randomIndex], hit.position, Quaternion.identity);
            }
        }
    }
}