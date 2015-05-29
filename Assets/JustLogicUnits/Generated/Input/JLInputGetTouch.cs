using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Input/Get Touch")]
[UnitFriendlyName("Get Touch")]
[UnitUsage(typeof(UnityEngine.Touch), HideExpressionInActionsList = true)]
public class JLInputGetTouch : JLExpression
{
    [Parameter(ExpressionType = typeof(System.Int32))]
    public JLExpression Index;

    public override object GetAnyResult(IExecutionContext context)
    {
        return UnityEngine.Input.GetTouch(Index.GetResult<System.Int32>(context));
    }
}