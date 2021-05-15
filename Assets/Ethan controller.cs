using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private GameObject _target;

    [SerializeField]
    private float _weightLeftHand;

    protected void OnAnimatorIK(int layerIndex)
    {
        _animator.SetIKPosition(goal: AvatarIKGoal.LeftHand, _target.transform.position);
        _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, _weightLeftHand);
    }
}
