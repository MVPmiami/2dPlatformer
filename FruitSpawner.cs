using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    private const string ObjectName = "Fruit";

    [SerializeField] private Transform _points;
    [SerializeField] private Sprite _sprite;

    private float spriteScale = 2.5f;
    void Start()
    {
        foreach (Transform point in _points)
        {
            GameObject spriteObject = new GameObject(ObjectName);
            SpriteRenderer spriteRenderer;

            if (spriteObject.TryGetComponent<SpriteRenderer>(out spriteRenderer))
            {
                spriteRenderer.sprite = _sprite;
                spriteRenderer.transform.localScale = new Vector3(spriteScale, spriteScale, 1);
                spriteObject.transform.position = point.position;
            }
        }
    }
}