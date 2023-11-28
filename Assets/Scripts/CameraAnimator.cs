using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimator : MonoBehaviour
{
    public Animator animator;

    public string shakeParameterName;

    public void Shake()
    {
        animator.SetTrigger(shakeParameterName);
    }
}
