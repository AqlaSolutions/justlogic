using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Navigation/Agent/Set Auto Traverse Off Mesh Link")]
[UnitFriendlyName("NavMeshAgent.Set Auto Traverse Off Mesh Link")]
[UnitUsage(typeof(System.Boolean))]
public class JLNavMeshAgentSetAutoTraverseOffMeshLink : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.NavMeshAgent))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Boolean))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.NavMeshAgent opValue = OperandValue.GetResult<UnityEngine.NavMeshAgent>(context);
        return opValue.autoTraverseOffMeshLink = Value.GetResult<System.Boolean>(context);
    }
}
