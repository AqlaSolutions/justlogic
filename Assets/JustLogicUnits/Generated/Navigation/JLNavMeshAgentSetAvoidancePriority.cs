using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Navigation/Agent/Set Avoidance Priority")]
[UnitFriendlyName("NavMeshAgent.Set Avoidance Priority")]
[UnitUsage(typeof(System.Int32))]
public class JLNavMeshAgentSetAvoidancePriority : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.NavMeshAgent))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Int32))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.NavMeshAgent opValue = OperandValue.GetResult<UnityEngine.NavMeshAgent>(context);
        return opValue.avoidancePriority = Value.GetResult<System.Int32>(context);
    }
}