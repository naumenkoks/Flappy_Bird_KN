using UnityEngine;

public class FeatherSpawner : MonoBehaviour
{
    public GameObject[] featherPrefabs;
    public float spawnInterval = 2f;
    public float spawnRangeX = 3f;
    public float spawnY = 6f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnFeather), 0f, spawnInterval);
    }

    void SpawnFeather()
    {
        int index = Random.Range(0, featherPrefabs.Length);
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);

        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);
        Instantiate(featherPrefabs[index], spawnPosition, Quaternion.identity);
    }
}
