using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TowerRotation : MonoBehaviour
{
    [SerializeField] private float rotationVel = 20f;

    [SerializeField] private float rotationAngle = 80f;

    private float minAngle = -45f;

    private float maxAngle = 45f;

    private Transform childObject;

    private void Start()
    {
        childObject = GetComponent<Transform>();
    }

    private void Update()
    {
        RotationTowerButton();
    }

    private void RotationTowerButton()
    {
        // ������� ����� ������
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(new Vector3(0, 0, rotationVel * Time.deltaTime));
        }

        // ������� ����� �����
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(new Vector3(0, 0, -rotationVel * Time.deltaTime));            
        }

        Debug.Log(childObject.localEulerAngles);

        // �������� ������� ���� �������� ��������� �������
        //Vector3 currentRotation = childObject.localEulerAngles;

        // ��� ������ ���������� �������, ����� ���������� �� � �������� �������� ������.
        //currentRotation.z = Mathf.Clamp(currentRotation.z, minAngle, maxAngle);

        // ��������� ������� ��������� ������� �����
        //childObject.localEulerAngles = currentRotation;        
    }
}
