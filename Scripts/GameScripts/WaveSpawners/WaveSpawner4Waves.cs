using UnityEngine;
using System.Collections;
public class WaveSpawner4Waves : MonoBehaviour
{
    public static int EnemiesAlive = 0;

    public Transform enemyPrefab;
    public Transform spawnPoint;
    public Transform enemyPrefab2;
    public Transform spawnPoint2;
    public Transform enemyPrefab3;
    public Transform spawnPoint3;
    public Transform enemyPrefab4;
    public Transform spawnPoint4;

    public float timeBetweenWaves = 7f;
    private float countdown = 2f;
    private int waveIndex = 0;

    private void Update()
    {
        if (EnemiesAlive > 0)
        {
            return;
        }


        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.8f);
        }
        if (waveIndex == 19)
        {
            // GameWon;
        }
    }



    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        Instantiate(enemyPrefab2, spawnPoint2.position, spawnPoint2.rotation);
        Instantiate(enemyPrefab3, spawnPoint3.position, spawnPoint3.rotation);
        Instantiate(enemyPrefab4, spawnPoint4.position, spawnPoint4.rotation);
        EnemiesAlive++;
    }




}
