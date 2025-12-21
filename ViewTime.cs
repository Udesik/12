using TMPro;
using UnityEngine;

public class ViewTime : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private TextMeshProUGUI _text;

    private void OnEnable()
    {
        _timer.TimerTicked += ChangeText;
    }

    private void OnDisable()
    {
        _timer.TimerTicked -= ChangeText;
    }

    private void ChangeText()
    {
        _text.text = _timer.CountValue.ToString("");
    }
}
