using UnityEngine;

public class Rockets : MonoBehaviour
{
    public float speed = 5f;
    public float lifeTime = 3f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    public void Initialize(float angle)
    {
        Vector2 direction = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad));
        rb.linearVelocity = direction * speed;
    }
}