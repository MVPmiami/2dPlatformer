using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _cameraZOffset;
    [SerializeField] private float _smoothSpeed;

    private void Update()
    {
        Vector3 targetPosition = new Vector3(_player.transform.position.x, _player.transform.position.y, _cameraZOffset);

        transform.position = Vector3.Lerp(transform.position, targetPosition, _smoothSpeed * Time.deltaTime);
    }
}
