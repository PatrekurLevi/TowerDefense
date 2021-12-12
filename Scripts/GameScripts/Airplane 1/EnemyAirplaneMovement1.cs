using UnityEngine;

public class EnemyAirplaneMovement1 : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;
    void Start()
    {
        target = WaypointsFlying1.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        this.transform.rotation = Quaternion.LookRotation(dir);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint()
    {
        if (wavepointIndex >= WaypointsFlying1.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = WaypointsFlying1.points[wavepointIndex];
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        WaveSpawner.EnemiesAlive--;
        WaveSpawner6Waves.EnemiesAlive--;
        Destroy(gameObject);
    }
}
