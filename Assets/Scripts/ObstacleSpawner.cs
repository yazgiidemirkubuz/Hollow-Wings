using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstaclePair; 

    public float spawnRange = 3.35f;
    private float startDelay = 1.0f; 
    private float spawnInterval = 2.0f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval); 

    }

    void SpawnRandomObject()
    {
        Vector3 spawnPos = new Vector3(transform.position.x , Random.Range(-spawnRange, spawnRange), transform.position.z);
        Instantiate(obstaclePair, spawnPos, obstaclePair.transform.rotation);  
    }
}
