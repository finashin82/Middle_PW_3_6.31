using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speedEnemy;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(0, 0, -speedEnemy * Time.deltaTime);
    }
}
