using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Camera/Get Aspect")]
[UnitFriendlyName("Camera.Get Aspect")]
[UnitUsage(typeof(System.Single), HideExpressionInActionsList = true)]
public class JLCameraGetAspect : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Camera))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.Camera opValue = OperandValue.GetResult<UnityEngine.Camera>(context);
        return opValue.aspect;
    }
}