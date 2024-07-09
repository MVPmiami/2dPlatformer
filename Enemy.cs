using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Start()
    {
        foreach (Enemy enemy in FindObjectsOfType<Enemy>())
            Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), enemy.GetComponent<Collider2D>());
    }
}
