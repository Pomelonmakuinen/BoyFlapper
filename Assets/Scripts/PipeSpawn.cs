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

    private System.Collections.IEnumerator SpawnPrefab()
    {
        while (true) // Infinite loop to keep spawning
        {
            // Spawn the prefab
            float randomY = Random.Range(minY, maxY);

            // Create a new Vector2 position for the prefab to spawn
            Vector2 spawnPosition = new Vector2(spawnXPosition, randomY);

            // Instantiate the prefab at the random position
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
