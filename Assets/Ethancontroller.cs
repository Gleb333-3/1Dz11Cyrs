using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ethancontroller : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private GameObject _target;

    [SerializeField]
    private GameObject _flashlight;

    [SerializeField]
    private float _weightLeftHand;

    protected void OnAnimatorIK(int layerIndex)
    {
        _weightLeftHand = (Vector3.Dot(transform.forward, _target.transform.position - transform.position) > 0) ? 1 : 0;

        _animator.SetIKPosition(goal: AvatarIKGoal.LeftHand, _target.transform.position);
        _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, _weightLeftHand);

        _animator.SetIKPosition(AvatarIKGoal.LeftHand, _flashlight.transform.position);
        _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);

    }
}
