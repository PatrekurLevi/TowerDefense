using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float Healthpoints;
    public float Worth;
    public GameObject Logichandler;
    // Start is called before the first frame update
    void Start()
    {
        Logichandler = GameObject.Find("Objectplacer"); 
    }



    // Update is called once per frame
    void Update()
    {
        if(Healthpoints <= 0)
        {
            Debug.Log("I'm dead");
            Logichandler.GetComponent<SpawnTurret>().Money = Logichandler.GetComponent<SpawnTurret>().Money + Worth;
            WaveSpawner.EnemiesAlive--;
            WaveSpawner2Waves.EnemiesAlive--;
            //WaveSpawner3Waves.EnemiesAlive--;
            //WaveSpawner4Waves.EnemiesAlive--;
            WaveSpawner6Waves.EnemiesAlive--;

            Destroy(gameObject);
        }
    }
}
