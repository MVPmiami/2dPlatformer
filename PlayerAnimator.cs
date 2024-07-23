using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string RunState = "RunState";

    [SerializeField] private Animator _animator;

    private int _runHash;

    private void Start()
    {
        _runHash = Animator.StringToHash(nameof(RunState));
    }

    public void Run()
    {
        _animator.SetBool(_runHash, true);
    }

    public void Idle()
    {
        _animator.SetBool(_runHash, false);
    }
}
