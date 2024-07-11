using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _player.FruitCountChanged += DisplayCount;
    }

    private void OnDisable()
    {
        _player.FruitCountChanged -= DisplayCount;
    }

    private void DisplayCount()
    {
        _text.text = _player.FruitCount.ToString();
    }
}
