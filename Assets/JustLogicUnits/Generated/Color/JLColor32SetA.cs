using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Color/Set A (Color32)")]
[UnitFriendlyName("Color32.Set A")]
[UnitUsage(typeof(System.Byte))]
public class JLColor32SetA : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Color32))]
    public JLExpression Target;

    [Parameter(ExpressionType = typeof(System.Byte))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.Color32 opValue = Target.GetResult<UnityEngine.Color32>(context);
        return opValue.a = Value.GetResult<System.Byte>(context);
    }
}