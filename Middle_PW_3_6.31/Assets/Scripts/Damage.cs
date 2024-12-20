using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float damage = 10f;

    private Health health;

    private void Start()
    {
        health = GetComponent<Health>();
    }    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IHealth ihealth))
        {
            ihealth.TakeDamage(damage);
        }
    }
}
