using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Vectors/Set/Set Y (Vector4)")]
[UnitFriendlyName("Set Y")]
[UnitUsage(typeof(System.Single), HideExpressionInActionsList = true)]
public class JLVector4SetY : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Vector4))]
    public JLExpression Target;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.Vector4 opValue = Target.GetResult<UnityEngine.Vector4>(context);
        return opValue.y = Value.GetResult<System.Single>(context);
    }
}
