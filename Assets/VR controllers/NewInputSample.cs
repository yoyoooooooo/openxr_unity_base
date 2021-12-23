using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.XR.OpenXR.Input;
using UnityEngine;

public class NewInputSample : MonoBehaviour
{
    [Tooltip("Action Reference that represents the control")]
    [SerializeField] private InputActionReference inputAction = null;

    protected virtual void OnEnable()
    {
        if(inputAction == null || inputAction.action == null)
            return;

        inputAction.action.started += OnActionStarted;
        inputAction.action.canceled += OnActionStopped;
    }

    protected virtual void OnDisable()
    {
        if(inputAction == null || inputAction.action == null)
            return;

        inputAction.action.started -= OnActionStarted;
        inputAction.action.canceled -= OnActionStopped;
    }

    protected void OnActionStarted(InputAction.CallbackContext ctx)
    {
        Debug.Log("Action started");
    }

    protected void OnActionStopped(InputAction.CallbackContext ctx)
    {
        Debug.Log("Action stopped");
    }
}