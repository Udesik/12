using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _delay = 1;
    [SerializeField] private MouseController _mouseController;

    public event Action TimerTicked;

    private bool _enabled = false;

    private void OnEnable()
    {
        _mouseController.MouseButtonClicked += StartTimer;
    }

    private void OnDisable()
    {
        _mouseController.MouseButtonClicked -= StartTimer;
    }

    private void StartTimer()
    {
        if (_enabled)
        {
            StopAllCoroutines();
        }
        else
        {
            StartCoroutine(Countdown());
        }

        _enabled = !_enabled;
    }

    private IEnumerator Countdown()
    {
        while (true)
        {
            yield return new WaitForSeconds(_delay);
            TimerTicked?.Invoke();
        }
    }
}
