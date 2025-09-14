using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_OneAnimationTriggers : MonoBehaviour
{
    private Enemy_One enemy => GetComponentInParent<Enemy_One>();
    private void AnimationTrigger()
    {
        enemy.AnimationFinishTrigger();
    }
}
