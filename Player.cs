using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GroundDetector _groundDetector;
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private PlayerAnimator _playerAnimator;
    [SerializeField] private PlayerCollector _playerCollector;

    private void FixedUpdate()
    {
        if (_inputReader.Direction != 0)
            _playerAnimator.Run();

        if (_inputReader.Direction == 0)
            _playerAnimator.Idle();

        if (_groundDetector.IsGround)
            _playerAnimator.Grounded();

        if (_inputReader.Direction != 0)
            _playerMover.Run(_inputReader.Direction);

        if (_inputReader.GetIsJump() && _groundDetector.IsGround)
            _playerMover.Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PickableItem fruit))
            _playerCollector.CollectFruit(fruit);
    }
}
