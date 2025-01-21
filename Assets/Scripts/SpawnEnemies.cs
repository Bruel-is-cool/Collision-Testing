using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject Slime;
    public Transform spawnPoint;

    float spawnInterval = 2f;
    float minimumSpawnInterval = 1f;
    float intervalDecrease = 0.1f;
    

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnTheEnemies());
    }

    IEnumerator SpawnTheEnemies()
    {
        while (true)
        {
            if (Slime != null && spawnPoint != null)
            {
                Instantiate(Slime, spawnPoint.position, spawnPoint.rotation);
            }

            else 
            {
                Debug.LogWarning("Object to spawn or spawn point is not set.");
            }

            yield return new WaitForSeconds(spawnInterval);

            spawnInterval = Mathf.Max(minimumSpawnInterval, spawnInterval - intervalDecrease);
        }
    }

}
