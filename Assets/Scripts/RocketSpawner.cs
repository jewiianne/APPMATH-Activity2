using UnityEngine;

public class RocketSpawner : MonoBehaviour
{
    public GameObject rocketsPrefab;
    public int rocketCount = 4;
    public int maxRocket = 8;
    public float fireInterval = 3f;

    private float fireTimer;

    void Update()
    {
        fireTimer += Time.deltaTime;
        if (fireTimer >= fireInterval)
        {
            SpawnRockets();
            fireTimer = 0f;
        }
    }

    public void SpawnRockets()
    {
        if (rocketCount <= 0) return;

        float angleStep = 360f / rocketCount;
        float angle = 0f;

        for (int i = 0; i < rocketCount; i++)
        {
            GameObject rocket = Instantiate(rocketsPrefab, transform.position, Quaternion.identity);
            Rockets rocketScript = rocket.GetComponent<Rockets>();
            rocketScript.Initialize(angle);
            angle += angleStep;
        }
    }

    public void IncreaseRocketCount(int amount)
    {
        rocketCount += amount;
        if (rocketCount > maxRocket)
        {
            rocketCount = maxRocket;
        }

        SpawnRockets();
    }
}