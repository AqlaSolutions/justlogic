using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Input/Get Ime Composition Mode")]
[UnitFriendlyName("Get Ime Composition Mode")]
[UnitUsage(typeof(UnityEngine.IMECompositionMode), HideExpressionInActionsList = true)]
public class JLInputGetImeCompositionMode : JLExpression
{
    public override object GetAnyResult(IExecutionContext context)
    {
        return UnityEngine.Input.imeCompositionMode;
    }
}