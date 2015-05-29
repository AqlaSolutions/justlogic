using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("GUILayout/MaxHeight")]
[UnitFriendlyName("GUILayout.MaxHeight")]
[UnitUsage(typeof(UnityEngine.GUILayoutOption), HideExpressionInActionsList = true)]
public class JLGuiLayoutMaxHeight : JLExpression
{
    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression MaxHeight;

    public override object GetAnyResult(IExecutionContext context)
    {
        return UnityEngine.GUILayout.MaxHeight(MaxHeight.GetResult<System.Single>(context));
    }
}