using UnityEngine;

public class CameraMover : MonoBehaviour
{
    private const float CameraZOffset = -1f;

    [SerializeField] private Player _player;

    private void Update()
    {
        transform.position = new Vector3(_player.transform.position.x,_player.transform.position.y, CameraZOffset);
    }
}
