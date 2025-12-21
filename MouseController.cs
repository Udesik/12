using System;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public event Action MouseButtonClicked;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseButtonClicked?.Invoke();
        }
    }
}
