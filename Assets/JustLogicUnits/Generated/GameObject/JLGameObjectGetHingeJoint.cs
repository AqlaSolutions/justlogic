using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Object/Get Hinge Joint")]
[UnitFriendlyName("Get Hinge Joint")]
[UnitUsage(typeof(UnityEngine.HingeJoint), HideExpressionInActionsList = true)]
public class JLGameObjectGetHingeJoint : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.GameObject))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.GameObject opValue = OperandValue.GetResult<UnityEngine.GameObject>(context);
        return opValue.GetComponent<HingeJoint>();
    }
}