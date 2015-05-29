using System.Reflection;
using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Object/Get Network View")]
[UnitFriendlyName("Get Network View")]
[UnitUsage(HideExpressionInActionsList = true)]
public class JLGameObjectGetNetworkView : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.GameObject))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.GameObject opValue = OperandValue.GetResult<UnityEngine.GameObject>(context);
        var m = typeof(GameObject).GetProperty("networkView", BindingFlags.Instance | BindingFlags.Public);
        if (m == null) return null;
        return m.GetValue(opValue, BindingFlags.Default, null, null, null);
    }
}