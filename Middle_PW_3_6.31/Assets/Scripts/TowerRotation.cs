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
        // Поворот башни вправо
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(new Vector3(0, 0, rotationVel * Time.deltaTime));
        }

        // Поворот башни влево
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(new Vector3(0, 0, -rotationVel * Time.deltaTime));            
        }

        Debug.Log(childObject.localEulerAngles);

        // получаем текущие углы вращения дочернего объекта
        //Vector3 currentRotation = childObject.localEulerAngles;

        // для каждой компоненты вектора, чтобы ограничить их в пределах заданных границ.
        //currentRotation.z = Mathf.Clamp(currentRotation.z, minAngle, maxAngle);

        // обновляем поворот дочернего объекта через
        //childObject.localEulerAngles = currentRotation;        
    }
}
