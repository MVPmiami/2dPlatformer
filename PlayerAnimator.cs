using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string RunState = "run";
    private const string GroundedState = "grounded";

    public void Grounded()
    {
        _animator.SetBool(GroundedState, true);
    }

    public void Run()
    {
        _animator.SetBool(RunState, true);
    }

    public void Idle()
    {
        _animator.SetBool(RunState, false);
    }
}
