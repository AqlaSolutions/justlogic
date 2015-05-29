using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Rect/Contains")]
[UnitFriendlyName("Rect.Contains")]
[UnitUsage(typeof(System.Boolean), HideExpressionInActionsList = true)]
public class JLRectContains : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Rect))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(UnityEngine.Vector2))]
    public JLExpression Point;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.Rect opValue = OperandValue.GetResult<UnityEngine.Rect>(context);
        return opValue.Contains(Point.GetResult<UnityEngine.Vector2>(context));
    }
}
