using UnityEngine;
using UnityEngine.InputSystem;

public class InputData : MonoBehaviour
{
    public Vector2 inputVector;

    public bool isAttack;

    public void OnEnable()
    {
        // Активируем наш созданный ранее контроллер ввода
        InputSystem_Actions inputActions = new InputSystem_Actions();

        inputActions.Enable();

        // Подписываемся на событие нажатия клавиш движения 
        inputActions.Player.Move.started += move => OnClickStarted(move);
        inputActions.Player.Move.performed += move => OnClickPerformed(move);
        inputActions.Player.Move.canceled += move => OnClickCanceled(move);

        // Подписываемся на событие нажатия клавиш атаки
        inputActions.Player.Attack.started += attack => OnPressStarted(attack);
        inputActions.Player.Attack.performed += attack => OnPressPerformed(attack);
        inputActions.Player.Attack.canceled += attack => OnPressCanceled(attack);
    }

    public void OnDisable()
    {
        // Отключаем контроллер ввода при деактивации компонента
        InputSystem_Actions inputActions = new InputSystem_Actions();

        inputActions.Disable();
    }    

    public void OnClickStarted(InputAction.CallbackContext context)
    {

    }     

    public void OnClickPerformed(InputAction.CallbackContext context)
    {
        inputVector = context.ReadValue<Vector2>();
    }

    public void OnClickCanceled(InputAction.CallbackContext context)
    {
        inputVector.x = 0;
    }

    public void OnPressStarted(InputAction.CallbackContext context)
    {
        
    }

    public void OnPressPerformed(InputAction.CallbackContext context)
    {
        isAttack = true;
    }

    public void OnPressCanceled(InputAction.CallbackContext context)
    {
        isAttack = false;
    }
}
