using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Physics/Constant Force/Get Relative Torque")]
[UnitFriendlyName("ConstantForce.Get Relative Torque")]
[UnitUsage(typeof(UnityEngine.Vector3), HideExpressionInActionsList = true)]
public class JLConstantForceGetRelativeTorque : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.ConstantForce))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.ConstantForce opValue = OperandValue.GetResult<UnityEngine.ConstantForce>(context);
        return opValue.relativeTorque;
    }
}