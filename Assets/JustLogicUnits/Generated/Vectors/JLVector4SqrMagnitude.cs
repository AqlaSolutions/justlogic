using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Vectors/Sqr Magnitude (Vector4)")]
[UnitFriendlyName("Sqr Magnitude")]
[UnitUsage(typeof(System.Single), HideExpressionInActionsList = true)]
public class JLVector4SqrMagnitude : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Vector4))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.Vector4 opValue = OperandValue.GetResult<UnityEngine.Vector4>(context);
        return opValue.SqrMagnitude();
    }
}
