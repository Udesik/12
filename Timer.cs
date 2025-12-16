using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay = 1;

    private int _countValue = 0;
    private bool _isCounting = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ToggleCounter();
        }
    }

    private void ToggleCounter()
    {
        if (!_isCounting)
        {
            StartCoroutine(Countdown());
        }
        else
        {
            StopAllCoroutines();
        }

        _isCounting = !_isCounting;
    }

    private IEnumerator Countdown()
    {
        while (true)
        {
            yield return new WaitForSeconds(_delay);
            _countValue++;
            DisplayCountdown(_countValue);
        }
    }

    private void DisplayCountdown(int number)
    {
        _text.text = number.ToString("");
    }
}
