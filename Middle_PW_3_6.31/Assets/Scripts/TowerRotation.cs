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
        // Поворот башни вправо
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
        }

        // Поворот башни влево
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(new Vector3(0, 0, -rotationSpeed * Time.deltaTime));            
        }
    }
}
