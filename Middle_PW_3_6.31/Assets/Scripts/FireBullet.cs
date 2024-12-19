using System.IO.Pipes;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Rendering;

public class FireBullet : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    [SerializeField] private LineRenderer lineRenderer;

    [SerializeField] private float rayDistance = 10f;

    [SerializeField] private float speedBullet = 20f;

    private RaycastHit hit;    

    void Update()
    {
        RaycastRender();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    /// <summary>
    /// �������� ���� � ��� ������������
    /// </summary>
    void RaycastRender()
    {
        Physics.Raycast(transform.position, transform.forward, out hit, rayDistance);

        lineRenderer.enabled = true;

        lineRenderer.SetPosition(0, transform.position);

        lineRenderer.SetPosition(1, hit.point);
    }

    /// <summary>
    /// ������� � ����������� ����
    /// </summary>
    void Shoot()
    {      
        Debug.Log(hit.transform.name);        

        // ������� ��������� � ������������� ��� � ����������� ����
        var fire = Instantiate(bullet, transform.position, Quaternion.LookRotation(hit.normal));

        // ������� ������ ��������� ��������� ����������
        fire.GetComponent<Rigidbody>().linearVelocity += transform.forward * speedBullet;
    }
}
