using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _fruitCount;

    public event Action<int> FruitCountChanged;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Fruit fruit))
        {
            _fruitCount++;
            Destroy(collision.gameObject);
            FruitCountChanged?.Invoke(_fruitCount);
        }
    }
}
