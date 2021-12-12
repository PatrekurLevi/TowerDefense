using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WaveSpawner : MonoBehaviour
{
    public static int EnemiesAlive = 0;
    
    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 7f;
    private float countdown = 2f;
    private int waveIndex = 0;

    //Text for UI
    public float MaxRound;
    public Text currentround;

    private void Update()
    {
        if (waveIndex == MaxRound && EnemiesAlive == 0)
        {
            Debug.Log("GameWon");
            SceneManager.LoadScene("Won");
            // GameWon;
        }

        currentround.text = waveIndex.ToString() + "/" + MaxRound;

        if (EnemiesAlive > 0 )
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

    IEnumerator SpawnWave ()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.8f);
        }

    }

    

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        EnemiesAlive++;
    }




}
