using UnityEngine;

public class Fruit : MonoBehaviour, IPickable
{
    public  void PickUp()
    {
        Destroy(gameObject);
    }
}