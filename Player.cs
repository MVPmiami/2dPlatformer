using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const string FruitName = "Fruit";

    private int _fruitCount;

    public int FruitCount => _fruitCount;
    public event Action FruitCountChanged;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == FruitName)
        {
            _fruitCount++;
            Destroy(collision.gameObject);
            FruitCountChanged?.Invoke();
        }
    }
}
