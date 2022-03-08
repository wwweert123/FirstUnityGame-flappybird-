using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] powerupPrefabs;
    public GameObject obstaclePrefab;

    private float xspawnPos = 32;
    private float ytoppipes = 5;
    private float ybotpipes = -6;
    private float ytoppowerUp = 8;
    private float ybotpowerUp = 0;

    private float startDelay = 2;
    private float obsSpawnTime = 3;
    private float puSpawnTime = 8;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnPipes", startDelay, obsSpawnTime);
        InvokeRepeating("spawnPowerup", startDelay, puSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GenerateSpawnPos(float top, float bottom)
    {
        float yspawnPos = Random.Range(bottom, top);
        Vector3 spawnPos = new Vector3(xspawnPos, yspawnPos, 0);

        return spawnPos;
    }

    void spawnPipes()
    {
        Instantiate(obstaclePrefab, GenerateSpawnPos(ytoppipes, ybotpipes), obstaclePrefab.transform.rotation);
    }

    void spawnPowerup()
    {
        int randomIndex = Random.Range(0, powerupPrefabs.Length);
        Instantiate(powerupPrefabs[randomIndex], GenerateSpawnPos(ytoppowerUp, ybotpowerUp), powerupPrefabs[randomIndex].transform.rotation);
    }
}
