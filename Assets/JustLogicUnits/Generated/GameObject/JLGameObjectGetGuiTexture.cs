using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Object/Get Gui Texture")]
[UnitFriendlyName("Get Gui Texture")]
[UnitUsage(typeof(UnityEngine.GUITexture), HideExpressionInActionsList = true)]
public class JLGameObjectGetGuiTexture : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.GameObject))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.GameObject opValue = OperandValue.GetResult<UnityEngine.GameObject>(context);
        return opValue.GetComponent<GUITexture>();
    }
}
