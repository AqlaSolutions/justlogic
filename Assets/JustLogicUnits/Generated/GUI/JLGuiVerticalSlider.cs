using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("GUI/VerticalSlider")]
[UnitFriendlyName("GUI.VerticalSlider")]
[UnitUsage(typeof(System.Single))]
public class JLGuiVerticalSlider : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.Rect))]
    public JLExpression Position;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression Value;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression TopValue;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression BottomValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        return UnityEngine.GUI.VerticalSlider(Position.GetResult<UnityEngine.Rect>(context), Value.GetResult<System.Single>(context), TopValue.GetResult<System.Single>(context), BottomValue.GetResult<System.Single>(context));
    }
}