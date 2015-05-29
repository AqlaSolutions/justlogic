using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Camera/Set Event Mask")]
[UnitFriendlyName("Camera.Set Event Mask")]
[UnitUsage(typeof(System.Int32))]
public class JLCameraSetEventMask : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Camera))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Int32))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.Camera opValue = OperandValue.GetResult<UnityEngine.Camera>(context);
        return opValue.eventMask = Value.GetResult<System.Int32>(context);
    }
}