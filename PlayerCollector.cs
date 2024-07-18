using System;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    private int _fruitCount;

    public event Action<int> FruitCountChanged;

    public void CollectFruit(PickableItem fruit)
    {
        _fruitCount++;
        fruit.PickUp();
        FruitCountChanged?.Invoke(_fruitCount);
    }
}
