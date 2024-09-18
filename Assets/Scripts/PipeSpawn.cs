using System.Collections;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject prefabToSpawn;

    public float spawnXPosition = 0f;
    public float spawnInterval = 2f;
    public float minY = -2.75f;
    public float maxY = 2.75f;

    public void Start()
    {
        InvokeRepeating("SpawnPrefab", 0f, spawnInterval);
    }

    private void SpawnPrefab()
    {
        float randomY = Random.Range(minY, maxY);
        Vector2 spawnPosition = new Vector2(spawnXPosition, randomY);
        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}
