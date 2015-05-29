using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Animation/State/Get Weight")]
[UnitFriendlyName("AnimationState.Get Weight")]
[UnitUsage(typeof(System.Single), HideExpressionInActionsList = true)]
public class JLAnimationStateGetWeight : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.AnimationState))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.AnimationState opValue = OperandValue.GetResult<UnityEngine.AnimationState>(context);
        return opValue.weight;
    }
}
