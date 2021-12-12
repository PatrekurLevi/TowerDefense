using UnityEngine;

public class bullet : MonoBehaviour
{

    private Transform target;
    public float speed = 70f;
    public float damage = 1f;

    public void Seek (Transform _target)
    {
        target = _target;  
    }


    // Update is called once per frame
    void Update()
    {
        
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime; 

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World); 


    }

    void HitTarget ()
    {
        Debug.Log("We hit it pog");
        target.GetComponent<EnemyHealth>().Healthpoints = target.GetComponent<EnemyHealth>().Healthpoints - damage; 
        Destroy(gameObject);
    }
}