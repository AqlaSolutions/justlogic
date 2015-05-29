using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Animator/Set Apply Root Motion")]
[UnitFriendlyName("Animator.Set Apply Root Motion")]
[UnitUsage(typeof(System.Boolean))]
public class JLAnimatorSetApplyRootMotion : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Animator))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Boolean))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.Animator opValue = OperandValue.GetResult<UnityEngine.Animator>(context);
        return opValue.applyRootMotion = Value.GetResult<System.Boolean>(context);
    }
}