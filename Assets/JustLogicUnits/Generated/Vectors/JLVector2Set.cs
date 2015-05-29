using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Vectors/Set/Set (Vector2)")]
[UnitFriendlyName("Set")]
[UnitUsage(typeof(UnityEngine.Vector2), HideExpressionInActionsList = true)]
public class JLVector2Set : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Vector2))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression NewX;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression NewY;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.Vector2 opValue = OperandValue.GetResult<UnityEngine.Vector2>(context);
        opValue.Set(NewX.GetResult<System.Single>(context), NewY.GetResult<System.Single>(context));
        return opValue;
    }
}