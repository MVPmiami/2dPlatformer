using System;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    private int _fruitCount;

    public event Action<int> FruitCountChanged;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out IPickable fruit))
            CollectFruit(fruit);
    }

    private void CollectFruit(IPickable fruit)
    {
        _fruitCount++;
        fruit.PickUp();
        FruitCountChanged?.Invoke(_fruitCount);
    }
}
