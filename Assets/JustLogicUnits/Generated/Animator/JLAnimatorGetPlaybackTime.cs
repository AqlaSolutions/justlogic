using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Animator/Get Playback Time")]
[UnitFriendlyName("Animator.Get Playback Time")]
[UnitUsage(typeof(System.Single), HideExpressionInActionsList = true)]
public class JLAnimatorGetPlaybackTime : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Animator))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.Animator opValue = OperandValue.GetResult<UnityEngine.Animator>(context);
        return opValue.playbackTime;
    }
}