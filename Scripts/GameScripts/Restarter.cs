using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WaveSpawner.EnemiesAlive = 0;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
