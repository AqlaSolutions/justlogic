using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Object/Find Game Object With Tag")]
[UnitFriendlyName("Find Game Object With Tag")]
[UnitUsage(typeof(UnityEngine.GameObject), HideExpressionInActionsList = true)]
public class JLGameObjectFindGameObjectWithTag : JLExpression
{
    [Parameter(ExpressionType = typeof(System.String))]
    public JLExpression Tag;

    public override object GetAnyResult(IExecutionContext context)
    {
        return UnityEngine.GameObject.FindGameObjectWithTag(Tag.GetResult<System.String>(context));
    }
}