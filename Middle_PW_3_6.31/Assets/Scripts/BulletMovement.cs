using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float timeDestroy = 2f;
    [SerializeField] private float speed = 3f;

    private Rigidbody rb;
       
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.linearVelocity = transform.forward * speed;
        Invoke("DestroyBullet", timeDestroy);
    }

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
