using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class PlayerMover : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string JumpButtonName = "Jump";
    private const string RunState = "run";
    private const string GroundedState = "grounded";
    private const string GroundName = "Ground";
    private const string JumpState = "jump";


    [SerializeField] private Rigidbody2D _rigidbody2d;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _localScale;

    private bool _grounded;

    private void Update()
    {
        float horizontalInput = Input.GetAxis(Horizontal);

        if (Input.GetButton(Horizontal))
            Run();

        if (Input.GetButtonDown(JumpButtonName) && _grounded)
            Jump();

        _animator.SetBool(RunState, horizontalInput != 0);
        _animator.SetBool(GroundedState, _grounded);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == GroundName)
            _grounded = true;
    }

    private void Jump()
    {
        _rigidbody2d.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
        _animator.SetTrigger(JumpState);
        _grounded = false;
    }

    private void Run()
    {
        float horizontalInput = Input.GetAxis(Horizontal);

        Vector3 direction = transform.right * horizontalInput;

        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, _speed * Time.deltaTime);

        if (horizontalInput > 0)
            transform.localScale = new Vector2(_localScale, _localScale);
        else if (horizontalInput < 0)
            transform.localScale = new Vector2(-_localScale, _localScale);
    }
}
