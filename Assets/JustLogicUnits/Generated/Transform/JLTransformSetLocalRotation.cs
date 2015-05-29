using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Transform/Set Local Rotation")]
[UnitFriendlyName("Set Local Rotation")]
[UnitUsage(typeof(UnityEngine.Quaternion))]
public class JLTransformSetLocalRotation : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Transform))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(UnityEngine.Quaternion))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.Transform opValue = OperandValue.GetResult<UnityEngine.Transform>(context);
        return opValue.localRotation = Value.GetResult<UnityEngine.Quaternion>(context);
    }
}