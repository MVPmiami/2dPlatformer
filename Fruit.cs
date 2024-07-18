public class Fruit : PickableItem
{
    public override void PickUp()
    {
        Destroy(gameObject);
    }
}