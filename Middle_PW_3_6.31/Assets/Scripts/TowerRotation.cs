using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TowerRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 20f;

    private void FixedUpdate()
    {
        RotationTowerButton();
    }

    private void RotationTowerButton()
    {
        // ������� ����� ������
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
        }

        // ������� ����� �����
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(new Vector3(0, 0, -rotationSpeed * Time.deltaTime));            
        }
    }
}
