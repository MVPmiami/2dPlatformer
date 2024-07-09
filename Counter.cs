using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _text;

    private void Update()
    {
        int count = _player.FruitCount;

        _text.text = count.ToString();
    }
}
