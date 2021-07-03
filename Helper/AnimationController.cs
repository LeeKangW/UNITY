using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationController : MonoBehaviour
{
    [SerializeField]
    Animator animator;

    public delegate void AnimTrigger(int state);
    public AnimTrigger animTriggerCallBack = null;
    public Action animEndCallback = null;

    private void Awake()
    {
        if(animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    #region Set Anim Parameter
    public void SetTrigger(string parameter) => animator.SetTrigger(parameter);
    public void SetBool(string parameter, bool value) => animator.SetBool(parameter, value);
    public void SetFloat(string parameter, float value) => animator.SetFloat(parameter, value);
    #endregion

    #region Animation Event
    public void AnimationTrigger(int state) => animTriggerCallBack?.Invoke(state);
    public void AnimationEndCallBack() => animEndCallback?.Invoke();
    #endregion
}
