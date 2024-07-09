using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _zOffset = -1f;

    void Update()
    {
        transform.position = new Vector3(_player.transform.position.x,_player.transform.position.y, _zOffset);
    }
}
