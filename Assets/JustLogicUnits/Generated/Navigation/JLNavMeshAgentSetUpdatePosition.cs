using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Navigation/Agent/Set Update Position")]
[UnitFriendlyName("NavMeshAgent.Set Update Position")]
[UnitUsage(typeof(System.Boolean))]
public class JLNavMeshAgentSetUpdatePosition : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.NavMeshAgent))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Boolean))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.NavMeshAgent opValue = OperandValue.GetResult<UnityEngine.NavMeshAgent>(context);
        return opValue.updatePosition = Value.GetResult<System.Boolean>(context);
    }
}