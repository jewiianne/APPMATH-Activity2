using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public int rocketChange = 2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var spawner = other.GetComponent<RocketSpawner>();
        if (spawner != null)
        {
            spawner.IncreaseRocketCount(rocketChange);
            Destroy(gameObject);
        }
    }
}