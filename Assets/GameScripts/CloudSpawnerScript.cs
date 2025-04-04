using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float minSpawnRate = 1f; // Minimum spawn time (seconds)
    public float maxSpawnRate = 6f; // Maximum spawn time (seconds)
    private float timer = 0f;
    private float nextSpawnTime;

    public float heightOffset = 7f; // Clouds' random height variation
    public float spawnX = 33f; // Spawning position (off-screen on the right)

    void Start()
    {
        SetNextSpawnTime();
        SpawnCloud();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= nextSpawnTime)
        {
            SpawnCloud();
            SetNextSpawnTime(); // Set new random spawn time
            timer = 0f;
        }
    }

    void SpawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(cloudPrefab, new Vector3(spawnX, Random.Range(lowestPoint, highestPoint), Random.Range(0, 20)), Quaternion.identity);
    }

    void SetNextSpawnTime()
    {
        nextSpawnTime = Random.Range(minSpawnRate, maxSpawnRate); // Random interval between 5-8 seconds
    }
}
