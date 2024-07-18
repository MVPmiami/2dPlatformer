using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private PlayerCollector _playerCollector;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _playerCollector.FruitCountChanged += DisplayCount;
    }

    private void OnDisable()
    {
        _playerCollector.FruitCountChanged -= DisplayCount;
    }

    private void DisplayCount(int fruitCount)
    {
        _text.text = fruitCount.ToString();
    }
}
