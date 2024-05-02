using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

//NO MODIFICAR
public class InputHandler : MonoBehaviour
{
    [SerializeField] private UnityEvent UpPress;
    [SerializeField] private UnityEvent DownPress;
    [SerializeField] private UnityEvent LeftPress;
    [SerializeField] private UnityEvent RightPress;
    [SerializeField] private UnityEvent RotateLPress;
    [SerializeField] private UnityEvent RotateRPress;

    public void OnUpPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            UpPress?.Invoke();
        }
    }

    public void OnDownPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            DownPress?.Invoke();
        }
    }

    public void OnLeftPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            LeftPress?.Invoke();
        }
    }

    public void OnRightPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            RightPress?.Invoke();
        }
    }

    public void OnRotateLeftPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            RotateLPress?.Invoke();
        }
    }

    public void OnRotateRightPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            RotateRPress?.Invoke();
        }
    }
}
