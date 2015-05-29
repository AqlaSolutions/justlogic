using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Input/Get Mouse Position")]
[UnitFriendlyName("Get Mouse Position")]
[UnitUsage(typeof(UnityEngine.Vector3), HideExpressionInActionsList = true)]
public class JLInputGetMousePosition : JLExpression
{
    public override object GetAnyResult(IExecutionContext context)
    {
        return UnityEngine.Input.mousePosition;
    }
}