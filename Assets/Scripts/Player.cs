using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character, InputSystem_Actions.IPlayerActions
{
    void Update()
    {
        
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        _mb.MoveCharacter(context.ReadValue<Vector2>() * 5);
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
    }

    public void OnJump(InputAction.CallbackContext context)
    {
    }
}
