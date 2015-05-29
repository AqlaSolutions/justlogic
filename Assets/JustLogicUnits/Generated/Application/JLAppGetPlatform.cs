using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Application/Get Platform")]
[UnitFriendlyName("Get Platform")]
[UnitUsage(typeof(UnityEngine.RuntimePlatform), HideExpressionInActionsList = true)]
public class JLAppGetPlatform : JLExpression
{
    public override object GetAnyResult(IExecutionContext context)
    {
        return UnityEngine.Application.platform;
    }
}