using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("GUILayout/VerticalSlider")]
[UnitFriendlyName("GUILayout.VerticalSlider")]
[UnitUsage(typeof(System.Single))]
public class JLGuiLayoutVerticalSlider : JLExpression
{
    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression Value;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression LeftValue;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression RightValue;

    [Parameter(ExpressionType = typeof(UnityEngine.GUILayoutOption))]
    public JLExpression[] Options;

    public override object GetAnyResult(IExecutionContext context)
    {
        return UnityEngine.GUILayout.VerticalSlider(Value.GetResult<System.Single>(context), LeftValue.GetResult<System.Single>(context), RightValue.GetResult<System.Single>(context), Options.GetResult<UnityEngine.GUILayoutOption>(context));
    }
}
