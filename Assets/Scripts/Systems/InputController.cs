using System;
using UnityEngine;
using UnityEngine.Events;

public class InputController : MonoBehaviour
{
    public UnityEvent EscapePressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            EscapePressed?.Invoke();
    }
}
