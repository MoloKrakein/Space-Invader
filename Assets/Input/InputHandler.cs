using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputHandler", menuName = "Scriptable Objects.Input Handler")]
public class InputHandler : ScriptableObject, CustomInput.IGameplayActions
{
    CustomInput customInput;

    public Action Interact;
    public Action<Vector2> SetDirection;

    // onEnabled
    private void OnEnable() {
        if(customInput == null)
        {
            customInput = new CustomInput();
        }
            customInput.Gameplay.SetCallbacks(this);
            customInput.Gameplay.Enable();
    }

    public void OnInterract(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            Debug.Log("Interract");
            Interact?.Invoke();
        }
    }

    public void OnSetDirection(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            Debug.Log("Set Direction");
            SetDirection?.Invoke(context.ReadValue<Vector2>());
        }
    }

    public void SetCustomInput(CustomInput customInput)
    {
        this.customInput = customInput;
    }

}
